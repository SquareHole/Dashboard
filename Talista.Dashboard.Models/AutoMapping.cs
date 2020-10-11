using AutoMapper;
using Talista.Dashboard.Models.DataContracts;
using Talista.Dashboard.Models.ServiceContracts;

namespace Talista.Dashboard.Models
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<WeatherForecast, WeatherForecastModel>();
        }
    }
}