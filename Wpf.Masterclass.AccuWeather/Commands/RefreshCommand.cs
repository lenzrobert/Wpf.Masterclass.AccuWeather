using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf.Masterclass.AccuWeather.Model;
using Wpf.Masterclass.AccuWeather.ViewModel;

namespace Wpf.Masterclass.AccuWeather.Commands
{
    public class RefreshCommand : ICommand
    {
        public ForecastViewModel ForecastViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public RefreshCommand(ForecastViewModel viewModel)
        {
            ForecastViewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           ForecastViewModel.GetWeather();
        }

       
    }
}
