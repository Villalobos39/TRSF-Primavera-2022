using System;
using System.Collections.Generic;
using System.Text;

namespace AlbumFotos
{
    public class PhotoAlbum
    {
        private int numberOfPages;

        public PhotoAlbum()
        {
            numberOfPages = 16;
        }

        public PhotoAlbum(int pages)
        {
            numberOfPages = pages;
        }
        public int GetNumberOfPages()
        {
            return numberOfPages;
        }

    }
}
