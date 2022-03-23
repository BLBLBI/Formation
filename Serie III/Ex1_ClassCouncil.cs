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
            Dictionary<string, List<float>> d = new Dictionary<string, List<float>>();

            using (StreamReader reader = new StreamReader(input))
            {
                string l;

                while ((l = reader.ReadLine()) != null)
                {
                    string[] t = l.Split(';');

                    if (d.ContainsKey(t[1]))
                        d[t[1]].Add(float.Parse(t[2]));
                    else
                        d.Add(t[1], new List<float>() { float.Parse(t[2]) });
                }
            }

            using (TextWriter writer = new StreamWriter(output))
            {
                foreach (KeyValuePair<string, List<float>> m in d)
                {
                    float s = 0;

                    for (int i=0; i<m.Value.Count;i++)
                    {
                        s += m.Value[i];
                    }

                    writer.WriteLine(m.Key + ';' + Math.Round(s/m.Value.Count, 1));
                }
            }
        }
    }
}
