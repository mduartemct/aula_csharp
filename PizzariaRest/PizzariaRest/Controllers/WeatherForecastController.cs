//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;

//namespace PizzariaRest.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class WeatherForecastController : ControllerBase
//    {
//        private static readonly string[] Summaries = new[]
//        {
//            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//        };

//        //private readonly ILogger<WeatherForecastController> _logger;

//        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
//        //{
//        //    //_logger = logger;
//        //}

//        [HttpGet]
//        public IEnumerable<WeatherForecast> Get()
//        {
//            var rng = new Random();
//            return Enumerable.Range(1, 5).Select(index => new
//            WeatherForecast
//            {
//                Date = DateTime.Now.AddDays(index),
//                TemperatureC = rng.Next(-20, 55),
//                Summary = Summaries[rng.Next(Summaries.Length)]
//            })
//            .ToArray();
//        }

//        [HttpPost]
//        public WeatherForecast Post(WeatherForecast item)
//        {
//            WeatherForecast novoWeatherForcast = new WeatherForecast
//            {
//                Date = DateTime.Now,
//                TemperatureC = item.TemperatureC,
//                Summary = item.Summary
//            };

//            return novoWeatherForcast;

//        }




//    }
//}
