using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Pull
{

    public class ForecastDisplay : Observer, DisplayElement {
		private float currentPressure = 29.92f;
        private float lastPressure;

        //compose the Concrete subject (WeatherData) here , write necessary code
        private IWeatherDataProvider weatherData;

        public ForecastDisplay(IWeatherDataProvider weatherData)
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
            lastPressure = currentPressure;
            currentPressure = weatherData.GetPressure();

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
