using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetosyConstructores
{
    public class Vino : Bebida, IBebidaAlcoholica
    {
        public string Tipo { get; set; }
        public int Alcohol { get; set; }

        public Vino(string tipo, int Cantidad, string Nombre = "Vino") : base(Nombre, Cantidad)
        {
            this.Tipo = tipo;
        }

        //metodo de interfaz
        public void MaximoRecomendado()
        {
            Console.WriteLine(this.Nombre); 
            Console.WriteLine("El maximo recomendado son 3 copas \n");
        }




        public override string ToString()
        {
            return base.ToString() + "Tipo: " + this.Tipo + " \n";
        }
    }
}
