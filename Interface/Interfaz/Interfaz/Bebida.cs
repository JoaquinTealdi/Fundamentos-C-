using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    internal class Bebida
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        //constructor
        public Bebida(string Nombre, int Cantidad)
        {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }

        public void Beber(int CuantoBebio)
        {
            this.Cantidad -= CuantoBebio;
        }

        public override string ToString()
        {
            return "Nombre: " + this.Nombre + " \n" + "Cantidad: " + this.Cantidad + " \n";
        }
    }
}

