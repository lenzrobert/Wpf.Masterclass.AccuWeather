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
                Headline = GetDefaultHeadline();
                DailyForecasts = GetDefaultForecasts();
            }
        }

        private List<DailyForecast> GetDefaultForecasts()
        {
           List<DailyForecast> defaultForecasts = new List<DailyForecast>();
           DailyForecast dayOne = new DailyForecast()
           {
               Date = DateTime.Now,
               Day = new DayPhase()
               {
                   Icon = 1,
                   IconPhrase = "day 1 default IconPhrase"
               },
               Night = new DayPhase()
               {
                   Icon = 1,
                   IconPhrase = "night 1 default IconPhrase"
               },
               Sources = new List<string>(),
               Temperature = new Temperature()
           };
            dayOne.Sources.Add("String Source 1");
            dayOne.Sources.Add("String Source 2");
            dayOne.Temperature.Maximum = new MetricsDetails()
            {
                Unit = "Temp Maximum Unit 1",
                UnitType = 1,
            };
            dayOne.Temperature.Minimum = new MetricsDetails()
            {
                Unit = "Temp Minimum Unit 1",
                UnitType = 1,
            };
            defaultForecasts.Add(dayOne);

            DailyForecast dayTwo = new DailyForecast()
            {
                Date = DateTime.Now.AddDays(1),
                Day = new DayPhase()
                {
                    Icon = 2,
                    IconPhrase = "day 2 default IconPhrase"
                },
                Night = new DayPhase()
                {
                    Icon = 1,
                    IconPhrase = "night 2 default IconPhrase"
                },
                Sources = new List<string>(),
                Temperature = new Temperature()
            };
            dayOne.Sources.Add("String Source 1");
            dayOne.Sources.Add("String Source 2");
            dayOne.Temperature.Maximum = new MetricsDetails()
            {
                Unit = "Temp Maximum Unit 2",
                UnitType = 2,
            };
            dayOne.Temperature.Minimum = new MetricsDetails()
            {
                Unit = "Temp Minimum Unit 2",
                UnitType = 2,
            };
            defaultForecasts.Add(dayTwo);

            return defaultForecasts;
        }

        private Headline GetDefaultHeadline() =>
            new Headline()
            {
                EffectiveDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(5),
                Category = "Headline Category",
                Text = "Headline Text"
            };
    }
}
