using System.Collections.Generic;

namespace Forecast.App.Models
{
    public class ForecastModel
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string timezone { get; set; }
        public Currently currently { get; set; }
        public Minutely minutely { get; set; }
        public Hourly hourly { get; set; }
        public Daily daily { get; set; }
        public Flags flags { get; set; }
        public int offset { get; set; }
        public string MessageErro { get; set; }
    }

    public class Currently
    {
        public int time { get; set; }
        public string summary { get; set; }
        public string icon { get; set; }
        public float nearestStormDistance { get; set; }
        public float nearestStormBearing { get; set; }
        public float precipIntensity { get; set; }
        public float precipProbability { get; set; }
        public float temperature { get; set; }
        public float apparentTemperature { get; set; }
        public float dewPoint { get; set; }
        public float humidity { get; set; }
        public float pressure { get; set; }
        public float windSpeed { get; set; }
        public float windGust { get; set; }
        public float windBearing { get; set; }
        public float cloudCover { get; set; }
        public float uvIndex { get; set; }
        public float visibility { get; set; }
        public float ozone { get; set; }
    }

    public class Minutely
    {
        public string summary { get; set; }
        public string icon { get; set; }
        public Datum[] data { get; set; }
    }

    public class Datum
    {
        public int time { get; set; }
        public float precipIntensity { get; set; }
        public float precipProbability { get; set; }
        public float precipIntensityError { get; set; }
        public string precipType { get; set; }
    }

    public class Hourly
    {
        public string summary { get; set; }
        public string icon { get; set; }
        public Datum1[] data { get; set; }
    }

    public class Datum1
    {
        public int time { get; set; }
        public string summary { get; set; }
        public string icon { get; set; }
        public float precipIntensity { get; set; }
        public float precipProbability { get; set; }
        public string precipType { get; set; }
        public float temperature { get; set; }
        public float apparentTemperature { get; set; }
        public float dewPoint { get; set; }
        public float humidity { get; set; }
        public float pressure { get; set; }
        public float windSpeed { get; set; }
        public float windGust { get; set; }
        public float windBearing { get; set; }
        public float cloudCover { get; set; }
        public float uvIndex { get; set; }
        public float visibility { get; set; }
        public float ozone { get; set; }
    }

    public class Daily
    {
        public string summary { get; set; }
        public string icon { get; set; }
        public List<DailyItem> data { get; set; }
    }

    public class DailyItem
    {
        public int time { get; set; }
        public string summary { get; set; }
        public string icon { get; set; }
        public float sunriseTime { get; set; }
        public float sunsetTime { get; set; }
        public float moonPhase { get; set; }
        public float precipIntensity { get; set; }
        public float precipIntensityMax { get; set; }
        public float precipIntensityMaxTime { get; set; }
        public float precipProbability { get; set; }
        public string precipType { get; set; }
        public float temperatureHigh { get; set; }
        public float temperatureHighTime { get; set; }
        public float temperatureLow { get; set; }
        public float temperatureLowTime { get; set; }
        public float apparentTemperatureHigh { get; set; }
        public float apparentTemperatureHighTime { get; set; }
        public float apparentTemperatureLow { get; set; }
        public float apparentTemperatureLowTime { get; set; }
        public float dewPoint { get; set; }
        public float humidity { get; set; }
        public float pressure { get; set; }
        public float windSpeed { get; set; }
        public float windGust { get; set; }
        public int windGustTime { get; set; }
        public int windBearing { get; set; }
        public float cloudCover { get; set; }
        public float uvIndex { get; set; }
        public float uvIndexTime { get; set; }
        public float visibility { get; set; }
        public float ozone { get; set; }
        public float temperatureMin { get; set; }
        public float temperatureMinTime { get; set; }
        public float temperatureMax { get; set; }
        public float temperatureMaxTime { get; set; }
        public float apparentTemperatureMin { get; set; }
        public float apparentTemperatureMinTime { get; set; }
        public float apparentTemperatureMax { get; set; }
        public float apparentTemperatureMaxTime { get; set; }
    }

    public class Flags
    {
        public string[] sources { get; set; }
        public float neareststation { get; set; }
        public string units { get; set; }
    }

}