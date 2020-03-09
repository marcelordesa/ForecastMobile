using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Forecast.App.Models;
using Forecast.App.Views;

namespace Forecast.App.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<DailyItem> Items { get; set; }
        public string Latitude { get; set; } = "37.8267";
        public string Longitude { get; set; } = "-122.4233";
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Forecast";
            Items = new ObservableCollection<DailyItem>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await forecastService.GetAllItemAsync(Latitude, Longitude);
                foreach (var item in items.data)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}