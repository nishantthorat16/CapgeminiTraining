using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WebApiBasics.Controllers
{
    [Route("api/weather")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        List<Weather> weather = new List<Weather>();

        public WeatherController()
        {
            weather.Add(new Weather("Bangalore", "Monday", 27.5F));
            weather.Add(new Weather("Bangalore", "Tuesday", 28.7F));
            weather.Add(new Weather("Bangalore", "Wednesday", 29.0F));
            weather.Add(new Weather("Bangalore", "Thursday", 27.5F));
            weather.Add(new Weather("Bangalore", "Friday", 22.5F));
            weather.Add(new Weather("Bangalore", "Saturday", 26.7F));
            weather.Add(new Weather("Bangalore", "Sunday", 26.1F));
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(weather);
        }

        [HttpGet("{city}")]
        public IActionResult Get(string city)
        {
            if (Regex.IsMatch(city, "^[a-zA-z ]*$"))
            {
                var w = weather.Where(d => d.CityName == city);

                if (w != null && w.Count() > 0)
                    return Ok(w);
                else
                    return NotFound($"No weather report found for {city}");
            }
            else
                return BadRequest("Invalid City Name");

        }

        [HttpPost]
        public IActionResult Post(Weather weatherRequest)
        {
            weather.Add(weatherRequest);
            return Ok(weather);
        }

        [HttpPut]
        public IActionResult Put(Weather weatherRequest)
        {
            if (weather.Any(d => d.CityName == weatherRequest.CityName
                             && d.WeekDay == weatherRequest.WeekDay))
                weather.Remove(weather.First(d => d.CityName == weatherRequest.CityName
                            && d.WeekDay == weatherRequest.WeekDay));

            weather.Add(weatherRequest);
            return Ok(weather);
        }

        [HttpDelete("{CityName}/{WeekDay}")]
        public IActionResult Delete(string cityname,string weekday)
        {

            var w = weather.FirstOrDefault(d => d.CityName == cityname
                            && d.WeekDay == weekday);

            if (w != null)
            {
                weather.Remove(w);
                return Ok(weather);
            }
            else
                return NotFound($"No wether report found for {cityname}/{weekday}");

           
        }
    }


    public class Weather
    {
        public string CityName { get; set; }
        public string WeekDay { get; set; }
        public float Temprature { get; set; }

        public Weather(string cityName, string weekDay, float temprature)
        {
            CityName = cityName;
            WeekDay = weekDay;
            Temprature = temprature;
        }

        public Weather() { }
    }
}
