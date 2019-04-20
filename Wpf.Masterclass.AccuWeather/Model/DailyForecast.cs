using System;
using System.Collections.Generic;

namespace Wpf.Masterclass.AccuWeather.Model
{
    public class DailyForecast : BasicForecast
    {
        private DateTime _date;
        private Temperature _temperature;
        private DayPhase _day;
        private DayPhase _night;
        private List<string> _sources;
        private List<AirAndPollen> _airAndPollen;

        public DateTime Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged("Date");
            }
        }

        public Temperature Temperature
        {
            get => _temperature;
            set
            {
                _temperature = value;
                OnPropertyChanged("Temperature");
            }
        }

        public DayPhase Day
        {
            get => _day;
            set
            {
                _day = value;
                OnPropertyChanged("Day");
            }
        }

        public DayPhase Night
        {
            get => _night;
            set
            {
                _night = value;
                OnPropertyChanged("Night");
            }
        }

        public List<string> Sources
        {
            get => _sources;
            set
            {
                _sources = value;
                OnPropertyChanged("Sources");
            }
        }

        public List<AirAndPollen> AirAndPollen
        {
            get => _airAndPollen;
            set
            {
                _airAndPollen = value;
                OnPropertyChanged("AirAndPollen");
            }
        }

    }
}
