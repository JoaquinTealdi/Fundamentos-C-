using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetosyConstructores
{

    public class Bebida
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        //constructor
        public Bebida(string nombre, int cantidad)
        {
            this.Nombre = nombre;   
            this.Cantidad = cantidad;
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
