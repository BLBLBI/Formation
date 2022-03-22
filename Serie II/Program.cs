using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[] { 1, -5, 10, -3, 0, 4, 2, -7 };
            int[] td = new int[] { -7, -5, -3, 0, 1, 2, 4, 10 };

            Console.WriteLine(Search.LinearSearch(t, 2));
            Console.WriteLine(Search.LinearSearch(t, -8));

            Console.WriteLine(Search.BinarySearch(td, 2));
            Console.WriteLine(Search.BinarySearch(td, -8));

            int[] te = Eratosthene.EratosthenesSieve(100);
            for (int i = 0; i < te.Length; i++)
            {
                if (te[i] != -1)
                    Console.Write($" {te[i]}");
            }
            Console.WriteLine("\n");

            Qcm q1 = new Qcm("Nom du Président", new string[] { "Chirac", "De Gaulle", "Macron" }, 3, 2);
            Qcm q2 = new Qcm("Pourquoi thomas existe?", new string[] { "¯\\_(ツ)_/¯" }, 1, 1);
            Qcm q3 = new Qcm("date!", new string[] { "21/03", "22/03", "23/03", "24/03", "25/03" }, 5, 7);

            Qcm[] q = new Qcm[] { q1, q2, q3 };

            Quiz.AskQuestions(q);




            // Keep the console window open
            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
