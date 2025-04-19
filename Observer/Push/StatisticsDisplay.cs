using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Push
{
    public class StatisticsDisplay : Observer, DisplayElement
    {

        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        // Task: compose the Concrete subject (WeatherData) here , write necessary code
        private Subject subject;

        public StatisticsDisplay(Subject weatherData)
        {
            subject = weatherData;
            subject.registerObserver(this);
        }

        public void removeObserver()
        {
            subject.removeObserver(this);

        }

        public void update(float temp, float humidity, float pressure)
        {
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
