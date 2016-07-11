using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLib
{
    public static class Extends
    {
        public static float CountHalf(this string s)
        {
            return s.Length / 2f;
        }
    }
}
