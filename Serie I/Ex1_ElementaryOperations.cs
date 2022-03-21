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
            //TODO
        }

        public static void Pow(int a, int b)
        {
            //TODO
        }
    }
}
