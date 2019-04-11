using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.Masterclass.AccuWeather.Model
{
    public class Moon
    {
        public DateTime Rise { get; set; }
        public DateTime Set { get; set; }
        public string Phase { get; set; }
        public int Age { get; set; }
    }
}
