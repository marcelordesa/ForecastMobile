using System.Threading.Tasks;

namespace Forecast.App.Services
{
    public interface IForecastService<T>
    {
        Task<T> GetAllItemAsync(string latitude, string longitude);
    }
}