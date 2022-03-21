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

            Pyramid.PyramidConstruction(10,false);
            Pyramid.PyramidConstruction(10,true);

            Console.WriteLine(Factorial.Factorial_(10));
            Console.WriteLine(Factorial.FactorialRecursive(10));

            PrimeNumbers.DisplayPrimes();
            int a = 18;
            int b = 45;
            Console.WriteLine($"pgcd {a}, {b} = {Euclide.Pgcd(a,b)}");
            Console.WriteLine($"pgcd {a}, {b} = {Euclide.PgcdRecursive(a,b)}");
            
            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
