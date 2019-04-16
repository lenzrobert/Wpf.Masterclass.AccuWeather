using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.Masterclass.AccuWeather.Model.Locations
{
    public class ForecastLocation : BasicForecast
    {
        private string _key;
        private string _localizedName;
        private Area _country;
        private Area _administrativeArea;


        public string Key
        {
            get => _key;
            set
            {
                _key = value;
                OnPropertyChanged("Key");
            } 
        }

        public string LocalizedName
        {
            get => _localizedName;
            set
            {
                _localizedName = value;
                OnPropertyChanged("LocalizedName");
            } 
        }

        public Area Country
        {
            get => _country;
            set
            {
                _country = value;
                OnPropertyChanged("LocalizedName");
            } 
        }

        public Area AdministrativeArea
        {
            get => _administrativeArea;
            set
            {
                _administrativeArea = value;
            } 
        }
    }
}
