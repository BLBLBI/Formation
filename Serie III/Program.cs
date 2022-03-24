using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            string input = path + @"\input.txt";
            string output = path + @"\output.txt";

            try
            {
                ClassCouncil.SchoolMeans(input, output);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("----------------------\n");

            List<int> i = new List<int>() { 2000, 5000, 10000 };
            int count = 20;

            SortingPerformance.DisplayPerformances(i, count);


            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
