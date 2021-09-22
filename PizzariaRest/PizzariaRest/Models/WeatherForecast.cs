using System;

namespace PizzariaRest
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int GetTemperatureF()
        {
            return 32 + (int)(TemperatureC / 0.5556);
        }

        public string Summary { get; set; }
    }
}
