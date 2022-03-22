using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public static class Eratosthene
    {
        public static int[] EratosthenesSieve(int n)
        {
            int min = 2;
            int max = (int)Math.Sqrt(n);
            int[] t = new int[n + 1];
            for (int i = 0; i < t.Length; i++)
                t[i] = i;


            while (min <= max)
            {
                for (int i = min * 2; i < t.Length; i += min)
                {
                    if (t[i] != -1)
                        t[i] = -1;
                }

                while (t[max] == -1 && min <= max)
                {
                    max--;
                }

                do
                {
                    min++;
                } while (t[min] == -1 && min <= max);
            }
            return t;
        }
    }
}
