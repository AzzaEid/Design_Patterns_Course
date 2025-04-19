using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Observer.Pull
{
    public class CurrentConditionsDisplay : Observer, DisplayElement {
		
        private float temperature;
        private float humidity;


        //compose the Concrete subject (WeatherData) here , write necessary code
        private IWeatherDataProvider weatherData;

        public CurrentConditionsDisplay(IWeatherDataProvider weatherData)
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
            temperature = weatherData.GetTemperature();
            humidity = weatherData.GetHumidity();
            display();
        }

        public void display()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Current conditions: " + temperature
                + "F degrees and " + humidity + "% humidity");
            Console.ResetColor();

        }
    }

}
