using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.Masterclass.AccuWeather.Model
{
    public class DayPhase
    {
        public int Icon { get; set; }
        public string IconPhrase { get; set; }
        public string LongPhrase { get; set; }
        public int ThunderstormProbability { get; set; }
        public int RainProbability { get; set; }
        public int SnowProbability { get; set; }
        public int IceProbability { get; set; }
        public Wind Wind { get; set; }
        public MetricsDetails Rain { get; set; }
        public MetricsDetails Snow { get; set; }
        public double HoursOfPrecipitation { get; set; }
        public double HoursOfRain { get; set; }
    }
}
