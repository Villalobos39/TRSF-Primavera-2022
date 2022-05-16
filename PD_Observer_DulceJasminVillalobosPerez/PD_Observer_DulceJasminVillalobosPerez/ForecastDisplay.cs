using System;
using System.Collections.Generic;
using System.Text;

namespace PD_Observer_DulceJasminVillalobosPerez
{
    public class ForecastDisplay : Observer, DisplayElement
    {
        private WeatherData weatherData;

        private float currentPressure = 2992/100;
        private float lastPressure;

        public ForecastDisplay(WeatherData weatherData)
        {
            ForecastDisplay forecastDisplay = this;
            forecastDisplay.weatherData = weatherData;
            this.weatherData.registerObserver(this);
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.lastPressure = currentPressure;
            this.currentPressure = pressure;
            this.display();
        }

        public void display()
        {
            Console.Write("PRONOSTICO: ");
            if ((currentPressure > lastPressure))
            {
                Console.Write("MEJORANDO EL CLIMA EN EL CAMINO!\n");
            }
            else if ((currentPressure == lastPressure))
            {
                Console.Write("MAS DE LO MISMO\n ");
            }
            else if ((currentPressure < lastPressure))
            {
                Console.Write("TENGA CUIDADO CON EL CLIMA MAS FRESCO Y LLUVIOSO \n");
            }

        }
    }
}