using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace apitesting.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet("Get2")]
        public IEnumerable<int> Get2()
        {
            return new int[] { 3, 12321, 1, 213, 213, 2112 };
        }
        [HttpGet("Get3")]
        public IEnumerable<int> Get3()
        {
            return new int[] { 3, 12321, 1, 213, 213, 2111112 };
        }
        [HttpGet("Get4")]
        public IEnumerable<int> Get4()
        {
            return new int[] { 3, 12321, 1, 213, 213, 2111112 };
        }
        [HttpGet("Get5")]
        public IEnumerable<string> Get5()
        {
            return new string[] { "asdf", "11", "sadfsfd" };
        }
    }
}
