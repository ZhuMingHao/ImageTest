using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;

namespace ImageTest.UWP
{
    public class DateToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {

            var temp = new BitmapImage();
            var assembly = typeof(ImageTest.App).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream(value as string);
            if (stream != null)
            {
                using (var memStream = new MemoryStream())
                {
                    stream.CopyTo(memStream);
                    memStream.Position = 0;
                    temp.SetSource(memStream.AsRandomAccessStream());
                }
            }
            return temp;
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value is string)
            {
                decimal returnDecimal;
                if (decimal.TryParse(value as string, out returnDecimal))
                {
                    return returnDecimal;
                }
            }
            return value;
        }
    }
}
