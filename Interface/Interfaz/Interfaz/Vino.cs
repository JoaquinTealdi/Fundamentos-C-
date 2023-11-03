using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    internal class Vino : Bebida, IBebidaAlcoholica
    {
        //implementar los metodos de la interfaz
        //metodo1
        public int alcohol { get; set; }
        //metodo2
        public void MaximoRecomendado()
        {
            Console.WriteLine(this.Nombre);
            Console.WriteLine("El maximo recomendado son 3 copas \n");
        }

        public string Tipo { get; set; }
        public Vino(string tipo, int Cantidad, string Nombre = "Vino") : base(Nombre, Cantidad)
        {
            this.Tipo = tipo;
        }

        public override string ToString()
        {
            return base.ToString() + "Tipo: " + this.Tipo + " \n";
        }
    }

}
