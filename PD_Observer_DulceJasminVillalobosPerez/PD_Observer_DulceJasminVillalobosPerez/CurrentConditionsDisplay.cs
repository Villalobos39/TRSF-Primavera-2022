using System;
using System.Collections.Generic;
using System.Text;

namespace PD_Observer_DulceJasminVillalobosPerez
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private WeatherData weatherData;
        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.registerObserver(this);
        }
        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.display();
        }
        public void display()
        {
            Console.WriteLine(("CONDICIONES ACTUALES: "
                            + (this.temperature + ("F GRADOS Y "
                            + (this.humidity + "% HUMEDAD")))));
        }
    }
}
