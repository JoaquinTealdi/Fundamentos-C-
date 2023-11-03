using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetosyConstructores
{
    internal class Cerveza : Bebida
    {
        public string Tipo { get; set; }
        public Cerveza(string tipo, int Cantidad, string Nombre = "Cerveza") : base(Nombre, Cantidad)
        {
            this.Tipo = tipo;
        }

        public override string ToString()
        {
            return base.ToString() + "Tipo: " + this.Tipo + " \n";
        }
    }

     
}
