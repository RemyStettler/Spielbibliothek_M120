using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M120Projekt.Helpers
{
    public class Validation
    {
        public bool IstName { get; set; }

        public bool IstPublisher { get; set; }

        public bool IstMindestalter { get; set; }

        public bool IstPreis { get; set; }

        public bool IstBewertung { get; set; }

        public bool IstDatum { get; set; }

        public bool NameValidieren(string name)
        {
            if(name.Length > 3 && name.Length < 30)
            {
                return true;
            }
            return false;
        }

        public bool PublisherValidieren(string publisher)
        {
            if(publisher.Length > 3 && publisher.Length < 30)
            {
                return true;
            }
            return false;
        }

        public bool DatumValidieren(System.Windows.Controls.DatePicker datePicker)
        {
            if(datePicker.SelectedDate != null)
            {
                return true;
            }
            return false;
        }

        public bool MindestalterValidieren(string mindestalter)
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

        public bool PreisValidieren(string preis)
        {
            try
            {
                double preisCheck = Convert.ToDouble(preis);
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^[0-9]*(?:\.[0-9]{1,2})?$");
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

        public bool Prüfen()
        {
            if(IstBewertung && IstDatum && IstMindestalter && IstName && IstPreis && IstPublisher)
            {
                return true;
            }
            return false;
        }

        public bool BewertungValidieren(string bewertung)
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
