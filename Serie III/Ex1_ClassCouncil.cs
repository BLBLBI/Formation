using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Serie_III
{
    public static class ClassCouncil
    {
        public static void SchoolMeans(string input, string output)
        {
            List<string[]> line = new List<string[]>();
            float histoire = 0;
            float maths = 0;
            int h = 0;
            int m = 0;

            using (TextReader reader = new StreamReader(input))
            {
                string l;

                while ((l = reader.ReadLine()) != null)
                {
                    line.Add(l.Split(';'));
                }
            }

            foreach (string[] s in line)
            {
                switch (s[1])
                {
                    case "Histoire":
                        histoire += float.Parse(s[2]);
                        h++;
                        break;
                    case "Maths":
                        maths += float.Parse(s[2]);
                        m++;
                        break;
                    default:
                        Console.WriteLine("???");
                        break;
                }
            }

            using (TextWriter writer = new StreamWriter(output))
            {
                writer.WriteLine("Histoire;" + Math.Round(histoire / h, 1));
                writer.WriteLine("Maths;" + Math.Round(maths / m, 1));
            }
        }
    }
}
