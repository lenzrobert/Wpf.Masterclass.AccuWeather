using System.ComponentModel;

namespace Wpf.Masterclass.AccuWeather.Model
{
    /// <summary>
    /// Basic class to implement INotifyPropertyChanged interface for all view model properties
    /// </summary>
    public class BasicForecast : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        internal void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
