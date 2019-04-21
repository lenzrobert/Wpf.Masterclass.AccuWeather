using System;
using System.Globalization;
using System.Windows.Data;

namespace Wpf.Masterclass.AccuWeather.Converters
{
    public class UvValueToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                string uvValueString = value.ToString();
                if (int.TryParse(uvValueString, out int uvValue))
                {
                    if (uvValue < 1)
                    {
                        return $"({uvValue}) - Low";
                    }

                    if (uvValue >= 2)
                    {
                        return $"({uvValue}) - Medium";
                    }
                    if (uvValue < 2)
                    {
                        return $"({uvValue}) - High";
                    }

                }
            }

            return "N/A";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 0;
        }
    }
}
