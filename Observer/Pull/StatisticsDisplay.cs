using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Pull
{
    public class StatisticsDisplay : Observer, DisplayElement {
	
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        
        //compose the Concrete subject (WeatherData) here , write necessary code
        private IWeatherDataProvider weatherData;

        public StatisticsDisplay(IWeatherDataProvider weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.registerObserver(this);
        }

        public void removeObserver()
        {
            weatherData.removeObserver(this);

        }


        public void update()
        {
            float temp = weatherData.GetTemperature();
            tempSum += temp;
            numReadings++;

            if (temp > maxTemp)
            {
                maxTemp = temp;
            }

            if (temp < minTemp)
            {
                minTemp = temp;
            }

            display();
        }

        public void display()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Avg/Max/Min temperature = " + (tempSum / numReadings)
                + "/" + maxTemp + "/" + minTemp);
            Console.ResetColor();
        }
    }

}
