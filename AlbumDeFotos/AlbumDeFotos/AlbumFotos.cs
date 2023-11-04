using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumDeFotos
{
    internal class AlbumFotos
    {
        private int NumPaginas { get; set; }

        public AlbumFotos()
        {
            NumPaginas = 16;
        }

        public AlbumFotos(int num)
        {
            NumPaginas = num;
        }

        public void GetNumeroPaginas() 
        {
            Console.WriteLine("El numero de paginas del album es " + NumPaginas);
        }
    }
}
