using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nueva Practica");
            List<string> Equipo = new List<string>()
            { "A","B","C","D","F","G","H"
            };
            List<string> Integrante = new List<string>()
            { "1","2","3","4","5","6","7","8","9" };
            List<string> Conforma = new List<string>();

            //for (int i = 0; i < 10; i++)
            //{
            //    Conforma.Add(Equipo[i] + "  "+Integrante[i] +"\n");
            //}
            //Console.WriteLine(Conforma);
           

            var Random = new Random();
            var listaEquipo = Equipo.OrderBy(item => Random.Next());
            var listaIntegrantes = Integrante.OrderBy(item => Random.Next());
            List<string> ConformaRandom = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(listaEquipo + "  ");
                Console.WriteLine(listaIntegrantes+ "  ");
                ConformaRandom.Add(Equipo[i] + "  " + Integrante[i]);
            }

            Console.WriteLine(ConformaRandom);
            //Conforma = listaEquipo.Concat(listaIntegrantes).ToList();

            listaEquipo.SelectMany(a => listaIntegrantes.Select(b => a + b));

            Console.WriteLine(listaEquipo.SelectMany(a => listaIntegrantes.Select(b => a + b)));
            //foreach (var item in listaEquipo)
            //{
            //    listaIntegrantes.add(item + "" + listaEquipo);
            //}

            Console.ReadLine();

        }
    }
}
