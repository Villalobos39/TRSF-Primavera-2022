using System;

namespace AlbumFotos
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoAlbum album1 = new PhotoAlbum();
            PhotoAlbum album2 = new PhotoAlbum(24);
            BigPhotoAlbum album3 = new BigPhotoAlbum();

            Console.WriteLine("EL ALBUM DE FOTOGRAFIA 1: TIENE {0} PAGINAS", album1.GetNumberOfPages());
            Console.WriteLine("EL ALBUM DE FOTOGRAFIA 2: TIENE {0} PAGINAS", album2.GetNumberOfPages());
            Console.WriteLine("EL ALBUM DE FOTOGRAFIA 3: TIENE {0} PAGINAS", album3.GetNumberOfPages());
        }
    }
}
