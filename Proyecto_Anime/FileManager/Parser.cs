using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Anime.FileManager
{
    public class Parser
    {
        public Anime Parse(string line)
        {
            var anime = new Anime();
            var values = line.Split(',');
            anime.Id_Anime = long.Parse(values[0]);
            anime.Titulo_Anime = values[1];
            return anime;
        }
    }
}
