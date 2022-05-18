using System;

namespace Proyecto_Anime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool No_Registros = true;
            do
            {
                Repositorio repository = new Repositorio();

                Console.Write("________________________ ~~~ LISTA DE ANIMES ~~~ ___________________________\n\n");
                foreach (var anime in repository.GetAll())
                {
                    Console.Write("   °°° TITULO DEL ANIME  :  " + anime.Titulo_Anime + "|  \n");
                    Console.Write("   ^^^ TIPO DE ANIME     :  " + anime.Tipo + "|  \n");
                    Console.Write("   ¬¬¬ GENEROS DEL ANIME :  "+ anime.Generos +"\n\n");
                    Console.Write("___________________________________________________________________________________\n");
                    Console.ReadLine();
                }
            } while (No_Registros);
            No_Registros = false;
        }
    }
}


     //anime.Id_Anime = 3;
     //anime.Titulo_Anime = "One Piece";
     //anime.Generos = Generos.Shounen | Generos.Aventura | Generos.Accion;
     //anime.Tipo = Tipos.Serie;
     //anime.productoras.Add(new Productora() { Nombre = "Tomoei Animation" });
     //No_Registros--;