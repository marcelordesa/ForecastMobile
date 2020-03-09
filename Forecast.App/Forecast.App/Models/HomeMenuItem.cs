using System;
using System.Collections.Generic;
using System.Text;

namespace Forecast.App.Models
{
    public enum MenuItemType
    {
        Forecast
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
