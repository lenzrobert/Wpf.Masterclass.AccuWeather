using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using Wpf.Masterclass.AccuWeather.Model;
using Wpf.Masterclass.AccuWeather.Model.Locations;

namespace Wpf.Masterclass.AccuWeather.ViewModel
{
    public class ForecastApi
    {
        /// <summary>
        /// Async method to get weather five days forecast from Accu Weather REST API
        /// </summary>
        /// <param name="citiyCode">city code</param>
        /// <returns>WeatherForecast object</returns>
        public static async Task<WeatherForecast> GetWeatherInformation5DaysAsync(string citiyCode)
        {

            if (!string.IsNullOrEmpty(citiyCode))
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

            return null;
        }

        /// <summary>
        /// Asyc method to get locatons from Accu Weather Autocomplete REST api
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
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
