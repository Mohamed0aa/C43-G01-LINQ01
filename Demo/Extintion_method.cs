using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Extension_method
    {

        public static int Reverse(this int x)
        {
            int r = 0, rr = 0;
            while (x > 0)
            {
                r = x % 10;

                rr = rr * 10 + r;
                x /= 10;
            }
            return rr;
        }
    }
}
