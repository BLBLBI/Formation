using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            PhoneBook p = new PhoneBook();
            p.DisplayPhoneBook();
            p.AddPhoneNumber("0626134518", "¯\\_(ツ)_/¯");
            p.AddPhoneNumber("0626234518", "¯\\_(ツ)_/");
            p.AddPhoneNumber("0024453485", "b");
            p.AddPhoneNumber("1234567891", "c");
            p.AddPhoneNumber("0156464656486463", "d");
            p.AddPhoneNumber("015646", "e");
            p.AddPhoneNumber("02354a8764", "e");
            p.DisplayPhoneBook();
            p.DeletePhoneNumber("0626234518");
            p.DisplayPhoneBook();
            */

            //BusinessSchedule edt = new BusinessSchedule();

            //edt.DisplayMeetings();

            Console.WriteLine(BracketsControl.BracketsControls("()"));

            // Keep the console window open
            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
