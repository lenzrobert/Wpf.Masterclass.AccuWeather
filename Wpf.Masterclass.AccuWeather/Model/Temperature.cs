namespace Wpf.Masterclass.AccuWeather.Model
{
    public class Temperature : BasicForecast
    {
        private MetricsDetails _minimum;
        private MetricsDetails _maximum;

        public MetricsDetails Minimum
        {
            get => _minimum;
            set
            {
                _minimum = value;
                OnPropertyChanged("Minimum");
            }
        }

        public MetricsDetails Maximum
        {
            get => _maximum;
            set
            {
                _maximum = value;
                OnPropertyChanged("Maximum");
            }
        }
    }
}
