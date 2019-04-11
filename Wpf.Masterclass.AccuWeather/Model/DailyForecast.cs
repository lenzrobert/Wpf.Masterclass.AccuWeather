using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.Masterclass.AccuWeather.Model
{
    public class DailyForecast
    {
        public DateTime Date { get; set; }
        public Sun Sun { get; set; }
        public Moon Moon { get; set; }
        public Temperature Temperature { get; set; }
        public RealFeelTemperature RealFeelTemperature { get; set; }
        public double HoursOfSun { get; set; }
        public DayPhase Day { get; set; }
        public DayPhase Night { get; set; }

    }
}
