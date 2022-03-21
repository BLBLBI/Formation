using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class SpeakingClock
    {
        public static string GoodDay(int heure)
        {
            string msg;
            if (heure < 6)
            {
                msg = "Merveilleuse nuit !";
            } 
            else if (heure < 12)
            {
                msg = "Bonne matinée !";
            }
            else if (heure == 12)
            {
                msg = "Bon appétit !";
            }
            else if (heure < 18)
            {
                msg = "Profitez de votre après-midi!";
            }
            else if (heure < 24)
            {
                msg = "Passez une bonne soirée!";
            }
            else
            {
                msg = "...";
            }
            return $"Il est {heure}, {msg}";
        }
    }
}
