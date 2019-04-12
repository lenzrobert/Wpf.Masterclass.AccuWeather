using System;

namespace Wpf.Masterclass.AccuWeather.Model
{
    public class Headline : BasicForecast
    {
        private DateTime _effectiveDate;
        private string _text;
        private string _category;
        private DateTime _endDate;

        public DateTime EffectiveDate
        {
            get => _effectiveDate;
            set
            {
                _effectiveDate = value;
                OnPropertyChanged("EffectiveDate");
            }
        }

        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        public string Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged("Category");
            }
        }

        public DateTime EndDate
        {
            get => _endDate;
            set
            {
                _endDate = value;
                OnPropertyChanged("EndDate");
            }
        }
    }
}
