using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    public class Cerveza : Bebida, IBebidaAlcoholica
    {
        public string Tipo { get; set; }
        public int Alcohol { get; set; }
        public Cerveza(string tipo, int Cantidad, string Nombre = "Cerveza") : base(Nombre, Cantidad)
        {
            this.Tipo = tipo;
        }

        //metodo de interfaz
        public void MaximoRecomendado()
        {
            Console.WriteLine(this.Nombre);
            Console.WriteLine("El maximo recomendado son 5 botellas");
        }

        public override string ToString()
        {
            return base.ToString() + "Tipo: " + this.Tipo + " \n";
        }
    }
}
