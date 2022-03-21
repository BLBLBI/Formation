using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class ElementaryOperations
    {
        public static void BasicOperation(int a, int b, char operation)
        {
            string res = "";

            switch(operation)
            {
                case '+':
                    res += a + b;
                    break;
                case '-':
                    res += a - b;
                    break;
                case '*':
                    res += a * b;
                    break;
                case '/':
                    res += b!=0?(a / b).ToString():"Opération invalide.";
                    break;
                default:
                    res += "Opération invalide.";
                    break;
            }

            Console.WriteLine($"{a} {operation} {b} = {res}");
        }

        public static void IntegerDivision(int a, int b)
        {
            string res;
            if (b != 0)
            {
                int q = a / b;
                int r = a % b;

                res = $"{a} = {q} * {b}";
                if (r != 0)
                    res += $" + {r}";
            }
            else
                res = $"{a} : {b} = Opération invalide.";

            Console.WriteLine(res);
        }

        public static void Pow(int a, int b)
        {
            string res = $"{a} ^ {b} = ";
            int r = a;
            if (b < 0)
            {
                res = "Opération invalide";
            } else if (b == 0)
            {
                res += "1";
            } else
            {
                for (int i = 0; i < b-1; i++)
                {
                    r *= a;
                }
                res += $"{r}";
            }
            Console.WriteLine(res);
        }
    }
}
