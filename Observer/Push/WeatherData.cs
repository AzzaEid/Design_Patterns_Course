using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Push
{

    public class WeatherData : Subject
    {

        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        // Task: create the constructor, make sure to initialize the obseervers collection
        public WeatherData()
        {
            observers = new List<Observer>();
        }


        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }

        public float getTemperature()
        {
            return temperature;
        }

        public float getHumidity()
        {
            return humidity;
        }

        public float getPressure()
        {
            return pressure;
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void notifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                Observer o = observers[i];
                o.update(temperature, humidity, pressure);
            }
        }
    }

}
