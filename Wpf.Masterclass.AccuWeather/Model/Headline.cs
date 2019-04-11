using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.Masterclass.AccuWeather.Model
{
    public class Headline
    {
        public DateTime EffectiveDate { get; set; }
        public string Text { get; set; }
        public string Category { get; set; }
        public DateTime EndDate { get; set; }
    }
}
