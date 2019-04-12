using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using Wpf.Masterclass.AccuWeather.Model;

namespace Wpf.Masterclass.AccuWeather.ViewModel
{
    public class ForecastApi
    {
        public static async Task<WeatherForecast> GetWeatherInformation5DaysAsync(string citiyCode)
        {
            
            string apiEndpoint = $"{Application.Current.TryFindResource("AccuWeatherBasicUrl")}daily/5day/{citiyCode}";
            string url = $"{apiEndpoint}?apikey={Application.Current.TryFindResource("AccuWeatherApiKey")}&details=true&metric=true";

            WeatherForecast forecast = null;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(json))
                {
                    forecast = JsonConvert.DeserializeObject<WeatherForecast>(json);
                }
            }

            return forecast;
        }
    }
}
