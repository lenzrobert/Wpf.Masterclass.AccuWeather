using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using Wpf.Masterclass.AccuWeather.Model;
using Wpf.Masterclass.AccuWeather.Model.Locations;

namespace Wpf.Masterclass.AccuWeather.ViewModel
{
    public class ForecastApi
    {
        public static async Task<WeatherForecast> GetWeatherInformation5DaysAsync(string citiyCode)
        {
            
            string apiEndpoint = $"{Application.Current.TryFindResource("AccuWeatherForecastBasicUrl")}daily/5day/{citiyCode}";
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

        public static async Task<List<ForecastLocation>> GetAutocompleteAsync(string query)
        {
            string url =
                $"{Application.Current.TryFindResource("AccuWeatherAutoCompleteBasicUrl")}{Application.Current.TryFindResource("AccuWeatherApiKey")}&q={query}";

            List<ForecastLocation> locations = new List<ForecastLocation>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(json))
                {
                    locations = JsonConvert.DeserializeObject<List<ForecastLocation>>(json);
                }
            }

            return locations;

        }
    }
}
