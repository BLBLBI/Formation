using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class Pyramid
    {
        public static void PyramidConstruction(int n, bool isSmooth)
        {
            for (int i = 1; i <= n; i++)
            {
                string e = "";
                for (int j = 0; j < n + n; j++)
                {
                    if (j <= n - i || j >= n + i)
                    {
                        e += " ";
                    }
                    else
                    {
                        e += i % 2 == 0 && isSmooth ? "-" : "+";
                    }
                }
                Console.WriteLine(e);
            }
        }
    }
}
