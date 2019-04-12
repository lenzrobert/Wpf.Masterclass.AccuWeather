namespace Wpf.Masterclass.AccuWeather.Model
{
    public class MetricsDetails : BasicForecast
    {
        private double _value;
        private string _unit;
        private int _unitType;

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

        public int UnitType
        {
            get => _unitType;
            set
            {
                _unitType = value;
                OnPropertyChanged("UnitType");
            }
        }
    }
}
