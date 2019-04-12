using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.Masterclass.AccuWeather.Model.Locations
{
    public class ForecastLocation
    {
        public int Version { get; set; }
        public string Key { get; set; }
        public string LocalizedName { get; set; }
        public Location Country { get; set; }
       
    }
}
