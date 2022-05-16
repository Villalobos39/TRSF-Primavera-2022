using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Anime
{
    public class Anime
    {
        public long Id_Anime { get; set; }
        public string Titulo_Anime { get; set; }
        public Generos Generos { get; set; }
        public Tipos Tipo { get; set; }
        public int Episodios { get; set; }
        public List<Productora> productoras { get; set; }

    }
}
