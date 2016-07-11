using System;
using System.Threading;

namespace ExampleLib
{
    /// <summary>
    /// MachineValueChanged defines a method signature for value changed event for Machine.
    /// </summary>
    /// <param name="sender">Defines the object that was fired current event.</param>
    /// <param name="value">Defines the new value for Machine.</param>
    public delegate void MachineValueChanged(Machine sender, int value);

    /// <summary>
    /// Machine represents a class that controls an hypothetical machine.
    /// </summary>
    public abstract class Machine
    {
        Thread thread;
        bool isRunning;

        /// <summary>
        /// Delay defines the delay between values changes.
        /// </summary>
        protected abstract int Delay { get; }

        /// <summary>
        /// IsRunning gets whether current machine is running.
        /// </summary>
        public bool IsRunning { get { return isRunning; } }

        /// <summary>
        /// ValueChanged is fired wherever the value is changed.
        /// </summary>
        public event MachineValueChanged ValueChanged;

        /// <summary>
        /// Started is fired when current machine is started.
        /// </summary>
        public event Action<Machine> Started;

        /// <summary>
        /// Stopped is fired when current machine is stopped.
        /// </summary>
        public event Action<Machine> Stopped;

        /// <summary>
        /// Start asynchronously starts current machine operation.
        /// </summary>
        public void Start()
        {
            thread = new Thread(StartAsync);
            thread.Start();
        }

        /// <summary>
        /// Stop asynchronously stops current machine operation.
        /// </summary>
        public void Stop()
        {
            isRunning = false;
        }

        /// <summary>
        /// StartAsync is called from Start new thread.
        /// </summary>
        private void StartAsync()
        {
            isRunning = true;
            int value = 0;
            bool asc = true;

            // Triggers Started event
            if (Started != null)
                Started(this);

            // Keeps running until 'isRunning' value becomes false.
            while (isRunning)
            {
                // Triggers ValueChanged event
                if (ValueChanged != null)
                    ValueChanged(this, value);

                // Increments value by 10 until 100
                // then decrements by 10 until 0 and so on.
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

            // Machine is stopping
            // then decrements value until becomes zero.
            while (value != 0)
            {
                value -= 10;

                // Triggers ValueChanged event
                if (ValueChanged != null)
                    ValueChanged(this, value);

                Thread.Sleep(Delay);
            }

            // Triggers Stopped event
            if (Stopped != null)
                Stopped(this);
        }
    }
}
