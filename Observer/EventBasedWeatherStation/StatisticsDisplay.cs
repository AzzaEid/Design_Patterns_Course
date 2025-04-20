using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.EventBasedWeatherStation
{
    public class StatisticsDisplay : DisplayElement
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;

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
            tempSum += temp;
            numReadings++;

            if (temp > maxTemp) maxTemp = temp;
            if (temp < minTemp) minTemp = temp;

            Display();
        }

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Avg/Max/Min temperature = {tempSum / numReadings}/{maxTemp}/{minTemp}");
            Console.ResetColor();
        }
    }

}
