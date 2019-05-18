using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace M120Projekt.Helpers
{
    public class BoolToStringConverter : BooleanToValueConverter<String> { }
    public class BoolToBrushConverter : BooleanToValueConverter<Brush> { }
    public class BoolToVisibilityConverter : BooleanToValueConverter<Visibility> { }
    public class BoolToObjectConverter : BooleanToValueConverter<Object> { }
}
