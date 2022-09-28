using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace FabricApp.ViewModels
{
    internal class RoleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((int)value == 0)
                return "Гость";
            if ((int)value == 1)
                return "Заказчик";
            if ((int)value == 2)
                return "Менеджер";
            if ((int)value == 3)
                return "Кладовщик";
            if ((int)value == 4)
                return "Директор";
            return "Неизвестно";

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
