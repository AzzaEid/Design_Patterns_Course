using Observer.Pull;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Push
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {

        private float temperature;
        private float humidity;


        // Task: compose the Concrete subject (WeatherData) here , write necessary code
        private Subject subject;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            subject = weatherData;
            subject.registerObserver(this);
        }

        public void removeObserver()
        {
            subject.removeObserver(this);

        }
        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
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
