﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    internal class A
    {
        protected int _a;
        protected int _b;

        public int C
        {
            get
            {
                int a = _a;
                int b = _b;
                if (a > 0)
                {
                    a--;
                    b++;
                    
                }
                return b;
            }
        }

        public A()
        {
            _a = 3;
            _b = 5;
        }

    }
}
