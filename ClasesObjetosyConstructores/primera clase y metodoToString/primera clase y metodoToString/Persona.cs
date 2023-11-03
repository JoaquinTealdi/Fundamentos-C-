using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primera_clase_y_metodoToString
{
    internal class Persona
    {
        private string Nombre { get; set; }

        public Persona(string nombre) 
        {
            this.Nombre = nombre;   
        }

        public void ToString() 
        {
            Console.WriteLine("¡Hola! Mi nombre es " + this.Nombre);
        }
    }
}
