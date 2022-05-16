using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Text;

namespace PD_Observer_DulceJasminVillalobosPerez
{
    public class WeatherData : Subject
    {
        private List<Observer>observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData() {  this.observers = new List<Observer>(); }
        public void registerObserver(Observer o) {  this.observers.Add(o); }
        public void removeObserver(Observer o)  { this.observers.Remove(o); }
        public void notifyObservers()
        {
            foreach (Observer observer in this.observers)
            { observer.update(this.temperature, this.humidity, this.pressure);  }
        }
        public void measurementsChanged() { this.notifyObservers(); }
        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            this.measurementsChanged();
        }
        public float getTemperature()  { return this.temperature; }
        public float getHumidity() {  return this.humidity; }
        public float getPressure() { return this.pressure; }
    }
}
