using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public static class Search
    {
        public static int LinearSearch(int[] tableau, int valeur)
        {
            for (int i = 0; i < tableau.Length; i++)
            {
                if (tableau[i] == valeur)
                    return i;
            }
            return -1;
        }

        public static int BinarySearch(int[] tableau, int valeur)
        {
            int res = -1;
            int g = 0;
            int d = tableau.Length - 1;
            int m = d / 2;
            int i = 0;

            while (res != valeur && i < tableau.Length)
            {
                if (tableau[m] < valeur)
                {
                    g = m;
                    m = d - g / 2;
                }
                else if (tableau[m] > valeur)
                {
                    d = m;
                    m = d - g / 2;
                }
                else
                    res = tableau[m];

                i++;
            }
            return res;
        }
    }
}
