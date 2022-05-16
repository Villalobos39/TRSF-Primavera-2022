using System;

namespace Proyecto_Anime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Anime anime = new Anime();
            int No_Registros = 0;
            Console.WriteLine("");

            do
            {
                anime.Id_Anime = 3;
                anime.Titulo_Anime = "One Piece";
                anime.Generos = Generos.Shounen | Generos.Aventura | Generos.Accion;
                anime.Tipo = Tipos.Serie;
                anime.productoras.Add(new Productora() { Nombre = "Tomoei Animation" });
                No_Registros--;
            } while (No_Registros==0);
            
        }
    }
}
