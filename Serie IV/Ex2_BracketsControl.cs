using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_IV
{
    public static class BracketsControl
    {
        static Stack<char> s = new Stack<char>();

        public static bool BracketsControls(string sentence)
        {
            foreach (char c in sentence)
            {
                if (c.Equals('{') || c.Equals('(') || c.Equals('['))
                {
                    s.Push(c);
                }
                else if (c.Equals('}') || c.Equals(')') || c.Equals(']'))
                {
                    if (!c.Equals(s.Pop()))
                        return false;
                }
            }

            return true;
        }
    }
}
