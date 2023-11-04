using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    public class Bebida
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        public Bebida(string nombre, int cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }

        public void Beber(int cuantoBebio)
        {
           Cantidad -= cuantoBebio;
        }

        public override string ToString()
        {
            return "Nombre: " + this.Nombre + " \n" + "Cantidad: " + this.Cantidad + " \n";
        }
    }
}

