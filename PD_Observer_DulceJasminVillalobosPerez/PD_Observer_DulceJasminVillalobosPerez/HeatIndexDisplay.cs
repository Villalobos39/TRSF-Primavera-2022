using System;
using System.Collections.Generic;
using System.Text;

namespace PD_Observer_DulceJasminVillalobosPerez
{
    public class HeatIndexDisplay : Observer, DisplayElement
    {
        float heatIndex = 0;
        private WeatherData weatherData;
        public HeatIndexDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.registerObserver(this);
        }
        public void update(float t, float rh, float pressure)
        {
            this.heatIndex = computeHeatIndex(t, rh);
            this.display();
        }

        private float computeHeatIndex(float t, float rh)
        {
            float index = ((float)(((16.923
                        + ((0.185212 * t)
                        + (((5.37941 * rh) - (0.100254
                        * (t * rh)))
                        + ((0.00941695
                        * (t * t))
                        + ((0.00728898
                        * (rh * rh))
                        + (((0.000345372
                        * (t
                        * (t * rh))) - (0.000814971
                        * (t
                        * (rh * rh))))
                        + (((1.02102E-05
                        * (t
                        * (t
                        * (rh * rh)))) - (3.8646E-05
                        * (t
                        * (t * t))))
                        + ((2.91583E-05
                        * (rh
                        * (rh * rh)))
                        + ((1.42721E-06
                        * (t
                        * (t
                        * (t * rh))))
                        + (((1.97483E-07
                        * (t
                        * (rh
                        * (rh * rh)))) - (2.18429E-08
                        * (t
                        * (t
                        * (t
                        * (rh * rh)))))) + (8.43296E-10
                        * (t
                        * (t
                        * (rh
                        * (rh * rh))))))))))))))) - (4.81975E-11
                        * (t
                        * (t
                        * (t
                        * (rh
                        * (rh * rh)))))))));
            return index;
        }

        public void display()
        {
            Console.WriteLine(("INDICE DE CALOR : " + heatIndex));
        }
    }
}
