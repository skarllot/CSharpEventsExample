namespace ExampleLib
{
    /// <summary>
    /// WeldingMachine represents a class that controls an hypothetical welding machine.
    /// </summary>
    public class WeldingMachine : Machine
    {
        /// <summary>
        /// Delay defines the delay between values changes.
        /// </summary>
        protected override int Delay { get { return 200; } }
    }
}
