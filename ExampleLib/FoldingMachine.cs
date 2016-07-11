namespace ExampleLib
{
    /// <summary>
    /// FoldingMachine represents a class that controls an hypothetical folding machine.
    /// </summary>
    public class FoldingMachine : Machine
    {
        /// <summary>
        /// Delay defines the delay between values changes.
        /// </summary>
        protected override int Delay { get { return 150; } }
    }
}
