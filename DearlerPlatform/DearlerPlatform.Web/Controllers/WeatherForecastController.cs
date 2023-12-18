using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DearlerPlatform.Core.Repository;
using DearlerPlatform.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DearlerPlatform.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IRepository<Customer> _customerRepo;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IRepository<Customer> customerRepo)
        {
            _logger = logger;
            this._customerRepo = customerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<Customer>> Get()
        {
            return await _customerRepo.GetListAsync(m=>m.Id == 5796);
        }
    }
}
