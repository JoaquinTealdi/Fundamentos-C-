using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumDeFotos
{
    internal class SuperAlbumFotos
    {
        private int NumPaginas { get; set; }

        public SuperAlbumFotos() 
        {
            NumPaginas = 64;
        }

        public void GetNumeroPaginas()
        {
            Console.WriteLine("El numero de paginas del Super Album es " + NumPaginas);
        }
    }
}
