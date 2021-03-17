using System;

namespace ApiDotNetCore
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperaturaCelsius { get; set; }

        public int TemperaturaF => 32 + (int)(TemperaturaCelsius / 0.5556);

        public string Summary { get; set; }
    }
}
