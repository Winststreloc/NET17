using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyBestProj.HomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson15_Homework.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public List<Transformer> Get()
        {
            return Deserialize.ReadingFile("D:\\Study\\NET17\\My-best-proj\\MyBestProj\\MyBestProj\\bin\\Debug\\netcoreapp3.1\\data.json");
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
    }
}
