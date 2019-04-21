using System.Collections.Generic;
using System.Collections.ObjectModel;
using Wpf.Masterclass.AccuWeather.Commands;
using Wpf.Masterclass.AccuWeather.Model;
using Wpf.Masterclass.AccuWeather.Model.Locations;

namespace Wpf.Masterclass.AccuWeather.ViewModel
{
    public class ForecastViewModel
    {
        /// <summary>
        /// Model - for View
        /// </summary>
        public WeatherForecast CurrentForecast { get; set; }
        
        /// <summary>
        /// Command for refresh button
        /// </summary>
        public RefreshCommand RefreshCommand { get; set; }
     
        /// <summary>
        /// Backing field for locations query
        /// </summary>
        private string _query;

        /// <summary>
        /// Locations Query
        /// </summary>
        public string Query
        {
            get => _query;
            set
            {
                _query = value;
                GetLocations();
            }
        }

        /// <summary>
        /// Backing field for selected location
        /// </summary>
        private ForecastLocation _selectedResult;

        /// <summary>
        /// Selected location
        /// </summary>
        public ForecastLocation SelectedResult
        {
            get => _selectedResult;
            set
            {
                _selectedResult = value;
                GetWeather();
            }
        }
   
        /// <summary>
        /// Observerable Collection for Locations list view
        /// </summary>
        public ObservableCollection<ForecastLocation> Locations { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public ForecastViewModel()
        {
           CurrentForecast = new WeatherForecast();
           Locations = new ObservableCollection<ForecastLocation>();
           RefreshCommand = new RefreshCommand(this);
          
        }

        /// <summary>
        /// Get Location - from REST webservice
        /// </summary>
        private async void GetLocations()
        {
            List<ForecastLocation> locations = await ForecastApi.GetAutocompleteAsync(Query);
            Locations.Clear();
            foreach (ForecastLocation location in locations)
            {
                Locations.Add(location);
            }
        }

        /// <summary>
        /// Get Forecast - from REST webservice
        /// </summary>
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
