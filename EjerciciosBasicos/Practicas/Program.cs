using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Practicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("REGISTROS EN LISTA");
            List<Registro> Registros = new List<Registro>();
            Registros.Add(new Registro(){Nombre="DULCE",Apellido="VILLALOBOS",Edad="23",Nacionalidad="MEXICANA"});
            Registros.Add(new Registro(){Nombre="ALEJO",Apellido="VILLALOBOS",Edad="21",Nacionalidad="MEXICANO"});
            Registros.Add(new Registro(){Nombre="BRAYAN",Apellido="PEREZ",Edad="18",Nacionalidad="MEXICANO"});
            Registros.Add(new Registro(){Nombre="JUNIOR",Apellido="MARTINEZ",Edad="12",Nacionalidad="MEXICANO"});
            Registros.Add(new Registro(){Nombre="KEVIN",Apellido="CARRILLO",Edad="19",Nacionalidad="MEXICANO"});
            Registros.Add(new Registro(){Nombre="EDWIN",Apellido="CARRILLO",Edad="16",Nacionalidad="MEXICANO"});

            var nquery =
               from itm in Registros select itm.Nombre + itm.Apellido + itm.Edad;

            foreach (var item in nquery)
            {
                Console.WriteLine("DATOS: " + item);
            }

            Console.ReadLine();
        }
    }
    class Registro
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Edad { get; set; }
        public String Nacionalidad { get; set; }
    }



}
