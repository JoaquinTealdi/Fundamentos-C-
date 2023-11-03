using ClasesObjetosyConstructores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.models
{
    public class Cerveza : Bebida, IBebidaAlcoholica
    {
        public int id { get; set; }
        public string Marca { get; set; }
        public int Alcohol { get; set; }

        public Cerveza(string nombre, string marca, int alcohol, int cantidad) : base(nombre, cantidad)
        {
            Marca = marca;
            Alcohol = alcohol;  
        }

        public Cerveza() : base(null, 0)
        {
        }

        public void MaximoRecomendado()
        {
            Console.WriteLine("El máximo permitido son 10 botellas");
        }
    }
}
