using ExampleLib;
using System;
using System.Windows.Forms;

namespace EventsExample
{
    public partial class Form1 : Form
    {
        FoldingMachine folder;
        PaintingMachine painter;
        WeldingMachine welder;
        Controller controller;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            controller = new Controller();
            folder = new FoldingMachine();
            painter = new PaintingMachine();
            welder = new WeldingMachine();
            
            // Listen for value changes on machines
            painter.ValueChanged += captureMachineChange;
            welder.ValueChanged += captureMachineChange;
            folder.ValueChanged += captureMachineChange;

            // Connect controller start and shutdown events on machines
            controller.OnStart += folder.Start;
            controller.OnStart += painter.Start;
            controller.OnStart += welder.Start;
            controller.OnShutdown += folder.Stop;
            controller.OnShutdown += painter.Stop;
            controller.OnShutdown += welder.Stop;
        }

        private void captureMachineChange(Machine sender, int value)
        {
            // Determine which progress bar represents sender machine
            ProgressBar pb;
            if (sender == folder)
                pb = pbFolder;
            else if (sender == welder)
                pb = pbWelder;
            else if (sender == painter)
                pb = pbPainter;
            else
                return;

            // Transfer progress bar value setting command to main thread
            // to avoid race condition when setting control state.
            Action call = () => pb.Value = value;
            pb.Invoke(call);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            controller.Start();
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            controller.Shutdown();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Determines whether any machine is running
            Machine machine;
            if (painter.IsRunning)
                machine = painter;
            else if (welder.IsRunning)
                machine = welder;
            else if (folder.IsRunning)
                machine = folder;
            else
            {
                // No machine is running then proceed closing
                base.OnClosing(e);
                return;
            }

            // A machine is running, stop it then close current form
            e.Cancel = true;
            machine.Stopped += captureMachineStop;
            machine.Stop();
        }

        private void captureMachineStop(Machine sender)
        {
            Action call = () => Close();
            Invoke(call);
        }
    }
}
