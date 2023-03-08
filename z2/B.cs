using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    internal class B : A
    {
        private int _d;

        public int C2 { get => _a + _b + _d; }

        public B() : base()
        {
        }

        public B(int a, int b, int d)
        {
            _a = a;
            _b = b;
            _d = d;
        }
    }
}
