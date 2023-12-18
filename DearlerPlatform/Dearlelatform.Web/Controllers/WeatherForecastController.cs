using DearlerPlatform.Core.Repository;
using DearlerPlatform.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Dearlelatform.Web.Controllers;


public class WeatherForecastController : BaseController
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IRepository<Customer> _repository;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        IRepository<Customer> repository)
    {
        _logger = logger;
        this._repository = repository;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IEnumerable<Customer>> Get()
    {
      return await _repository.GetListAsync(m=>m.Id==1);
    }
}
