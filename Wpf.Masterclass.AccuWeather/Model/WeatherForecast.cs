using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace Wpf.Masterclass.AccuWeather.Model
{
    public class WeatherForecast : BasicForecast
    {
        private List<DailyForecast> _dailyForecasts;
        private Headline _headline;


        public Headline Headline
        {
            get => _headline;
            set
            {
                _headline = value;
                OnPropertyChanged("Headline");
            }
        }

        public List<DailyForecast> DailyForecasts
        {
            get => _dailyForecasts;
            set
            {
                _dailyForecasts = value;
                OnPropertyChanged("DailyForecasts");
            }
        }

        public WeatherForecast()
        {
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                Headline = new Headline()
                {
                    EffectiveDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(5),
                    Category = "Headline Category",
                    Text = "Headline Text"
                }; 
            }
        }
    }
}
