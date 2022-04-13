using System;

namespace ValidarCURP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROCESO DE REGISTRO O VALIDACION");

            CrearCURP crearCURP = new CrearCURP();

            crearCURP.Insertar_datos();

            //Nombre: DULCE JASMIN                              D      [0]      L   [2]
            //Apellido VILLALOBOS                               VI     [0,1]    L   [2]
            //Apellido PEREZ:                                   P      [0]      R   [2]
            //Fecha de Naciemiento: 11-12-1998                  981211
            //Genero: MUJER.                                    M      [0]
            //ESTADO BAJA CALIFORNIA.                           BC     [IF]
            //Lugar de Nacimiento: México, TIJUANA.
            // PRIMERA CONSONANTES DE LOS APELLIDOS Y NOMBRE    LRL    
            //CURP: VIPD 981211 M BC LRL 09

            Console.ReadLine();
        }
    }
}
