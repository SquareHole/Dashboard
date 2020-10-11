using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Talista.Dashboard.Models.DataContracts;
using Talista.Dashboard.Models.ServiceContracts;

namespace Talista.Dashboard.Services
{
    public class WeatherForecastService
    {
        private readonly IMapper _mapper;

        public WeatherForecastService(IMapper mapper)
        {
            _mapper = mapper;
        }
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public async Task<WeatherForecastModel[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            var result = await Task.FromResult(Enumerable.Range(1, 5)
                .Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }));

            return result.Select(x => _mapper.Map<WeatherForecastModel>(x)).ToArray();
        }
        
        
    }
}