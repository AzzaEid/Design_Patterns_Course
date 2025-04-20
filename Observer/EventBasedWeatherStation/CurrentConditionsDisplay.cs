using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.EventBasedWeatherStation
{
    public class CurrentConditionsDisplay : DisplayElement
    {
        private float temperature;
        private float humidity;

        public void Subscribe(WeatherData weatherData)
        {
            weatherData.WeatherDataChanged += Update;
        }

        public void Unsubscribe(WeatherData weatherData)
        {
            weatherData.WeatherDataChanged -= Update;
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
            Console.ResetColor();
        }
    }
}
