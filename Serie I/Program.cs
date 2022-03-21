using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    class Program
    {
        static void Main(string[] args)
        {
            ElementaryOperations.BasicOperation(1, 10, '/');

            ElementaryOperations.IntegerDivision(3, 0);

            ElementaryOperations.Pow(3, 8);
            
            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
