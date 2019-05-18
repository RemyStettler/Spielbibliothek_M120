using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M120Projekt.Helpers
{
    public static class CheckBoxConverter
    {
        public static bool ConvertCheckBox(bool? isChecked)
        {
            if (isChecked == true)
            {
                return true;
            }
            return false;
        }
    }
}
