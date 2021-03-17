using System;

namespace ApiDotNetCore
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperaturaC { get; set; }

        public int TemperaturaF => 32 + (int)(TemperaturaC / 0.5556);

        public string Summary { get; set; }
    }
}
