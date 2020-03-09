using System;
using System.Net.Http;
using System.Threading.Tasks;
using Forecast.App.Models;
using Newtonsoft.Json;

namespace Forecast.App.Services
{
    public class ForecastService : IForecastService<Daily>
    {
        public async Task<Daily> GetAllItemAsync(string latitude, string longitude)
        {
            ForecastModel forecastModel = new ForecastModel();

            try
            {
                HttpClient client;

                client = new HttpClient();
                client.MaxResponseContentBufferSize = 256000;

                HttpResponseMessage response = null;
                var uri = new Uri($"{App.UrlApi}{latitude},{longitude}");
                response = await client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    forecastModel = JsonConvert.DeserializeObject<ForecastModel>(content);
                }
                else
                {
                    forecastModel.MessageErro = "Erro ao tentar retornar pesquisa do API";
                    return forecastModel.daily;
                }
            }
            catch(Exception ex)
            {
                forecastModel.MessageErro = $"Erro ao tentar retornar pesquisa do API: {ex.Message}";
            }

            return forecastModel.daily;
        }
    }
}