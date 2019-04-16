using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.Masterclass.AccuWeather.Model.Locations
{
    public class Area : BasicForecast
    {
        private string _id;
        private string _localizedName;

        public string ID
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged("ID");
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
    }
}
