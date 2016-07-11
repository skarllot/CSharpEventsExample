using ExampleLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller;
        FoldingMachine folder;
        PaintingMachine painter;
        WeldingMachine welder;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            controller = new Controller();
            folder = new FoldingMachine();
            painter = new PaintingMachine();
            welder = new WeldingMachine();

            painter.ValueChanged += captureMachineChange;
            welder.ValueChanged += captureMachineChange;
            folder.ValueChanged += captureMachineChange;

            controller.OnStart += folder.Start;
            controller.OnStart += painter.Start;
            controller.OnStart += welder.Start;
            controller.OnShutdown += folder.Stop;
            controller.OnShutdown += painter.Stop;
            controller.OnShutdown += welder.Stop;
        }

        private void captureMachineChange(Machine sender, int value)
        {
            ProgressBar progressbar;
            if (sender == folder)
                progressbar = pbFolder;
            else if (sender == welder)
                progressbar = pbWelder;
            else if (sender == painter)
                progressbar = pbPainter;
            else
                return;

            // Throws an exception
            //pb.Value = value;

            progressbar.Dispatcher.Invoke(() => progressbar.Value = value);
            //progressbar.Dispatcher.Invoke(delegate ()
            //{
            //    progressbar.Value = value;
            //});
        }

        private void btnInitialize_Click(object sender, RoutedEventArgs e)
        {
            controller.Start();
        }

        private void btnShutdown_Click(object sender, RoutedEventArgs e)
        {
            controller.Shutdown();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Machine machine;
            if (painter.IsRunning)
                machine = painter;
            else if (welder.IsRunning)
                machine = welder;
            else if (folder.IsRunning)
                machine = folder;
            else
            {
                base.OnClosing(e);
                return;
            }

            e.Cancel = true;
            machine.Stopped += captureMachineStop;
            machine.Stop();
        }

        private void captureMachineStop(Machine sender)
        {
            Dispatcher.Invoke(() => Close());
        }

        private void chkMachine_Checked(object sender, RoutedEventArgs e)
        {
            string strA = "Hello";
            float num = strA.CountHalf();
            /*CheckBox checkbox;
            if (sender == chkFolder)
                checkbox = chkFolder;
            else if (sender == chkPainter)
                checkbox = chkPainter;
            else if (sender == chkWelder)
                checkbox = chkWelder;
            else
                return;*/
        }
    }
}
