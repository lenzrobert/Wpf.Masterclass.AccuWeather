using System.Collections.Generic;
using System.Collections.ObjectModel;
using Wpf.Masterclass.AccuWeather.Commands;
using Wpf.Masterclass.AccuWeather.Model;
using Wpf.Masterclass.AccuWeather.Model.Locations;

namespace Wpf.Masterclass.AccuWeather.ViewModel
{
    public class ForecastViewModel
    {
       public WeatherForecast CurrentForecast { get; set; }
       public RefreshCommand RefreshCommand { get; set; }

        private string _query;

        public string Query
        {
            get => _query;
            set
            {
                _query = value;
                GetLocations();
            }
        }

        private ForecastLocation _selectedResult;

        public ForecastLocation SelectedResult
        {
            get => _selectedResult;
            set
            {
                _selectedResult = value;
                GetWeather();
            }
        }
   
        public ObservableCollection<ForecastLocation> Locations { get; set; }

        public ForecastViewModel()
        {
           CurrentForecast = new WeatherForecast();
           Locations = new ObservableCollection<ForecastLocation>();
           RefreshCommand = new RefreshCommand(this);
        }

        private async void GetLocations()
        {
            List<ForecastLocation> locations = await ForecastApi.GetAutocompleteAsync(Query);
            Locations.Clear();
            foreach (ForecastLocation location in locations)
            {
                Locations.Add(location);
            }
        }


        internal async void GetWeather()
        {
            if (SelectedResult.Key != null)
            {
                WeatherForecast forecast = await ForecastApi.GetWeatherInformation5DaysAsync(SelectedResult.Key);
                if (forecast != null)
                {
                    CurrentForecast.Headline = forecast.Headline;
                    CurrentForecast.DailyForecasts = forecast.DailyForecasts;
                } 
            }
           
        }


    }
}
