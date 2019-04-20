namespace Wpf.Masterclass.AccuWeather.Model
{
    public class AirAndPollen : BasicForecast
    {
        private string _name;
        private string _category;
        private int _categoryValue;
        private string _type;
        private int _value;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged("Value");
            }
        }

        public string Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged("Category");
            }
        }

        public int CategoryValue
        {
            get => _categoryValue;
            set
            {
                _categoryValue = value;
                OnPropertyChanged("CategoryValue");
            }
        }

        public string Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
        }
    }
}
