namespace ExampleLib
{
    /// <summary>
    /// PaintingMachine represents a class that controls an hypothetical painting machine.
    /// </summary>
    public class PaintingMachine : Machine
    {
        /// <summary>
        /// Delay defines the delay between values changes.
        /// </summary>
        protected override int Delay { get { return 420; } }
    }
}
