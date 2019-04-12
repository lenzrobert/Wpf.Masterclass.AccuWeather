namespace Wpf.Masterclass.AccuWeather.Model
{
    public class DayPhase : BasicForecast
    {
        private int _icon;
        private string _iconPhrase;

        public int Icon
        {
            get => _icon;
            set
            {
                _icon = value;
                OnPropertyChanged("Icon");
            }
        }

        public string IconPhrase
        {
            get => _iconPhrase;
            set
            {
                _iconPhrase = value;
                OnPropertyChanged("IconPhrase");
            }
        }
    }
}
