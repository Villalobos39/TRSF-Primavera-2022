using System;
using System.Collections.Generic;
using System.Text;

namespace PD_Observer_DulceJasminVillalobosPerez
{
    public class StatisticsDisplay : Observer, DisplayElement
    {

        private float maxTemp = 0;
        private float minTemp = 200;
        private float tempSum = 0;
        private int numReadings;

        private WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.registerObserver(this);
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.tempSum = (tempSum + temp);
            this.numReadings++;
            if ((temp > maxTemp))
            {
                maxTemp = temp;
            }

            if ((temp < minTemp))
            {
                minTemp = temp;
            }

            display();
        }

        public void display()
        {
            Console.WriteLine(("TEMPERATURA MEDIA/MAXIMA/MINIMA = "
                            + ((tempSum / numReadings) + ("/ "
                            + (maxTemp + ("/ " + minTemp))))));
        }
    }
}
