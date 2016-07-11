﻿using ExampleLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
            ProgressBar pb;
            if (sender == folder)
                pb = pbFolder;
            else if (sender == welder)
                pb = pbWelder;
            else if (sender == painter)
                pb = pbPainter;
            else
                return;

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
            Action call = () => Close();
            Invoke(call);
        }
    }
}
