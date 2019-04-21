namespace Wpf.Masterclass.AccuWeather.Model
{
    public class MetricsDetails : BasicForecast
    {
        private double _value;
        private string _unit;
       

        public double Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged("Value");
            }
        }

        public string Unit
        {
            get => _unit;
            set
            {
                _unit = value;
                OnPropertyChanged("Unit");
            }
        }


        public override string ToString() => $"{Value} {Unit}°";
    }
}
