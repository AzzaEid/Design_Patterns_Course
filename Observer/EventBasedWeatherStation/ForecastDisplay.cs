using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.EventBasedWeatherStation
{
    public class ForecastDisplay : DisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;

        public void Subscribe(WeatherData weatherData)
        {
            weatherData.WeatherDataChanged += Update;
        }

        public void Unsubscribe(WeatherData weatherData)
        {
            weatherData.WeatherDataChanged -= Update;
        }

        public void Update(float temp, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Forecast: ");
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
            Console.ResetColor();
        }
    }

}
