using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Anime
{
    public class Repositorio
    {
        public List<Anime> GetAll()
        {
            var listAnimeStrings = FileManager.FileReader.ReadFile(@"C:\Users\dulso\OneDrive\Documentos\Anime\TablaAnime.csv");

            List<Anime> ListMovies = new List<Anime>();
            foreach (var item in listAnimeStrings.Skip(1))
            {
                var parser = new FileManager.Parser();
                var movie = parser.Parse(item);
                ListMovies.Add(movie);
            }

            return ListMovies;
        }
    }
}
