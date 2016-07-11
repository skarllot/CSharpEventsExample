using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExampleLib
{
    public delegate void MachineValueChanged(Machine sender, int value);

    public abstract class Machine
    {
        Thread thread;
        bool isRunning;

        protected abstract int Delay { get; }
        public bool IsRunning { get { return isRunning; } }

        public event MachineValueChanged ValueChanged;
        public event Action<Machine> Started;
        public event Action<Machine> Stopped;

        public void Start()
        {
            thread = new Thread(StartAsync);
            thread.Start();
        }

        public void Stop()
        {
            isRunning = false;
        }

        private void StartAsync()
        {
            isRunning = true;
            int value = 0;
            bool asc = true;

            if (Started != null)
                Started(this);

            while (isRunning)
            {
                if (ValueChanged != null)
                    ValueChanged(this, value);

                if (asc)
                    value += 10;
                else
                    value -= 10;

                if (value >= 100)
                    asc = false;
                if (value <= 0)
                    asc = true;

                Thread.Sleep(Delay);
            }

            while (value != 0)
            {
                value -= 10;

                if (ValueChanged != null)
                    ValueChanged(this, value);

                Thread.Sleep(Delay);
            }

            if (Stopped != null)
                Stopped(this);
        }
    }
}
