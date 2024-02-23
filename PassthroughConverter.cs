using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewNullBindingContext
{
    public class PassthroughConverter : IValueConverter
    {
        static int count = 0;
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            count++;
            return $"{value} binding count={count}";
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
