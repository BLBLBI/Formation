using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class Euclide
    {
        public static int Pgcd(int a, int b)
        {
            int r = a % b;

            while (r != 0)
            {
                a = b;
                b = r;

                r = a % b;
            }

            return b;
        }

        public static int PgcdRecursive(int a, int b)
        {
            return a % b != 0 ? PgcdRecursive(b, a % b) : b;
        }
    }
}
