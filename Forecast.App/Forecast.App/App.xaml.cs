using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Forecast.App.Services;
using Forecast.App.Views;

namespace Forecast.App
{
    public partial class App : Application
    {
        public const string UrlApi = "https://api.darksky.net/forecast/49c30368d7261d0d5f7c1175843396ff/";
        public App()
        {
            InitializeComponent();

            DependencyService.Register<ForecastService>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
