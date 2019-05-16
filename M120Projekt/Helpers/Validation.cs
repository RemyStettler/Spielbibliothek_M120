using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M120Projekt.Helpers
{
    public static class Validation
    {
        public static bool NameValidieren(string name)
        {
            if(name.Length > 3 && name.Length < 30)
            {
                return true;
            }
            return false;
        }

        public static bool PublisherValidieren(string publisher)
        {
            if(publisher.Length > 3 && publisher.Length < 30)
            {
                return true;
            }
            return false;
        }

        public static bool MindestalterValidieren(string mindestalter)
        {
            try
            {
                int alter = Convert.ToInt32(mindestalter);
                if (alter <= 99)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public static bool PreisValidieren(string preis)
        {
            try
            {
                double preisCheck = Convert.ToDouble(preis);
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\d+\.\d{1,2})");
                System.Text.RegularExpressions.Match match = regex.Match(preis);
                if (match.Success)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public static bool BewertungValidieren(string bewertung)
        {
            try
            {
                int sterne = Convert.ToInt32(bewertung);
                if(sterne >= 0 && sterne <= 5)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
