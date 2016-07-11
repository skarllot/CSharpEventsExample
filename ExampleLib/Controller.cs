namespace ExampleLib
{
    /// <summary>
    /// ShutdownMachine defines a method signature for shutdown event.
    /// </summary>
    public delegate void ShutdownMachine();

    /// <summary>
    /// StartMachine defines a method signature for start event.
    /// </summary>
    public delegate void StartMachine();

    /// <summary>
    /// A Controller handle the startup and shutdown of multiples machines.
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// Event fired when a startup was requested.
        /// </summary>
        public event StartMachine OnStart;

        /// <summary>
        /// Event fired when a shutdown was requested.
        /// </summary>
        public event ShutdownMachine OnShutdown;

        /// <summary>
        /// Start request startup of plugged machines.
        /// </summary>
        public void Start()
        {
            if (OnStart != null)
                OnStart();
        }

        /// <summary>
        /// Shutdown request shutdown of plugged machines.
        /// </summary>
        public void Shutdown()
        {
            if (OnShutdown != null)
                OnShutdown();
        }
    }
}
