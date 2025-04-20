using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.EventBasedWeatherStation
{

    public delegate void WeatherDataChangedHandler(float temp, float humidity, float pressure);

    public class WeatherData
    {
        public event WeatherDataChangedHandler WeatherDataChanged;

        private float temperature;
        private float humidity;
        private float pressure;

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            OnMeasurementsChanged();
        }

        protected void OnMeasurementsChanged()
        {
            WeatherDataChanged?.Invoke(temperature, humidity, pressure);
        }
    }
}
