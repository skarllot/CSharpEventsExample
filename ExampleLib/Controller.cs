using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLib
{
    public delegate void ShutdownMachine();
    public delegate void StartMachine();

    public class Controller
    {
        public event StartMachine OnStart;
        public event ShutdownMachine OnShutdown;

        public void Start()
        {
            if (OnStart != null)
                OnStart();
        }

        public void Shutdown()
        {
            if (OnShutdown != null)
                OnShutdown();
        }
    }
}
