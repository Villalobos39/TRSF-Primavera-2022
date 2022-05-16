using System;
using System.Collections.Generic;
using System.Collections;
using System.Globalization;
using System.Threading;
using System.Text;

namespace PD_Observer_DulceJasminVillalobosPerez
{
    class Program
    {
        public static void Main(String[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            Console.WriteLine("DULCE JASMIN VILLAOBOS PEREZ");
            Console.ReadLine();
            Console.WriteLine("--- MAQUINA DEL CLIMA : PRIMERA ENTRADA ---");
            weatherData.setMeasurements(80, 65, 30.4f);
            Console.WriteLine("\n--- MAQUINA DEL CLIMA : SEGUNDA ENTRADA ---");
             weatherData.setMeasurements(82, 70, 29.2f);
             Console.WriteLine("\n--- MAQUINA DEL CLIMA : TERCERA ENTRADA ---");
             weatherData.setMeasurements(78, 90, 29.2f);

             Console.WriteLine("\n--- MAQUINA DEL CLIMA : CUARTA ENTRADA ---");
             weatherData.removeObserver(forecastDisplay);
             weatherData.setMeasurements(62, 90, 28.1f);

            Console.ReadLine();
        }
    }
}


