using Observer.Pull;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Push
{

    public class ForecastDisplay : Observer, DisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;

        // Task: compose the Concrete subject (WeatherData) here , write necessary code
        private Subject subject;

        public ForecastDisplay(Subject weatherData)
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
            lastPressure = currentPressure;
            currentPressure = pressure;

            display();
        }
        public void display()
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
            else if (currentPressure < lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
            Console.ResetColor();
        }
    }

}
