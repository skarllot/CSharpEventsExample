using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExampleLib
{
    public class PaintingMachine : Machine
    {
        protected override int Delay { get { return 420; } }
    }
}
