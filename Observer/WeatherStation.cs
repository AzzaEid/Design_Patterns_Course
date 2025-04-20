using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class WeatherStation
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("==== Weather Station Demo ====");
            Console.WriteLine("Choose mode:");
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pull");
            Console.WriteLine("3. Event");
            Console.Write("Enter your choice: ");
            var choice = Console.ReadLine();

            if (choice == "1")
            {
                RunPushMode();
            }
            else if (choice == "2")
            {
                RunPullMode();
            }
            else if (choice == "3")
            {
                RunEventMode();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

        }

        static void RunPushMode()
        {
            Console.WriteLine("\n-- Running in PUSH mode --\n");

            var weatherData = new Push.WeatherData();  // namespace is Push

            var currentDisplay = new Push.CurrentConditionsDisplay(weatherData);
            var forecastDisplay = new Push.ForecastDisplay(weatherData);
            var statisticsDisplay = new Push.StatisticsDisplay(weatherData);

            Console.WriteLine("Updating WeatherData with: 80, 65, 30.4f");
            weatherData.setMeasurements(80, 65, 30.4f);
            Console.WriteLine("\t---\t\n");

            Console.WriteLine("Updating WeatherData with: 82, 70, 29.2f");
            weatherData.setMeasurements(82, 70, 29.2f);
            Console.WriteLine("\t---\t\n");

            Console.WriteLine("Updating WeatherData with: 78, 90, 29.2f");
            weatherData.setMeasurements(78, 90, 29.2f);
            weatherData.removeObserver(statisticsDisplay);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n[Removed StatisticsDisplay from observers]");
            Console.ResetColor();

            Console.WriteLine("\nUpdating WeatherData again with: 75, 60, 29.5f");
            weatherData.setMeasurements(75, 60, 29.5f);
        }
    

        static void RunPullMode()
        {
            Console.WriteLine("\n-- Running in PULL mode --\n");

            var weatherData = new Pull.WeatherData();  // namespace is Pull

            var currentDisplay = new Pull.CurrentConditionsDisplay(weatherData);
            var forecastDisplay = new Pull.ForecastDisplay(weatherData);
            var statisticsDisplay = new Pull.StatisticsDisplay(weatherData);

            Console.WriteLine("Updating WeatherData with: 80, 65, 30.4f");
            weatherData.setMeasurements(80, 65, 30.4f);
            Console.WriteLine("\t---\t\n");

            Console.WriteLine("Updating WeatherData with: 82, 70, 29.2f");
            weatherData.setMeasurements(82, 70, 29.2f);
            Console.WriteLine("\t---\t\n");

            Console.WriteLine("Updating WeatherData with: 78, 90, 29.2f");
            weatherData.setMeasurements(78, 90, 29.2f);
            weatherData.removeObserver(statisticsDisplay);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n[Removed StatisticsDisplay from observers]");
            Console.ResetColor();

            Console.WriteLine("\nUpdating WeatherData again with: 75, 60, 29.5f");
            weatherData.setMeasurements(75, 60, 29.5f);
        }
        public static void RunEventMode()
        {
            var weatherData = new EventBasedWeatherStation.WeatherData();

            var currentDisplay = new EventBasedWeatherStation.CurrentConditionsDisplay();
            var forecastDisplay = new EventBasedWeatherStation.ForecastDisplay();
            var statisticsDisplay = new EventBasedWeatherStation.StatisticsDisplay();

            currentDisplay.Subscribe(weatherData);
            forecastDisplay.Subscribe(weatherData);
            statisticsDisplay.Subscribe(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);

            Console.WriteLine("\nRemoving StatisticsDisplay...\n");
            statisticsDisplay.Unsubscribe(weatherData);

            weatherData.SetMeasurements(75, 60, 29.5f);
        }
    }
    

}
