using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Masterclass.AccuWeather.Model;

namespace Wpf.Masterclass.AccuWeather.ViewModel
{
    public class ForecastViewModel
    {
       public WeatherForecast CurrentForecast { get; set; }

       public ForecastViewModel()
       {
           CurrentForecast = new WeatherForecast();
       }
    }
}
