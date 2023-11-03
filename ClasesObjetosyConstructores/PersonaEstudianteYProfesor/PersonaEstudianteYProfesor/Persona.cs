using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaEstudianteYProfesor
{
    internal class Persona
    {
        protected int Edad { get; set; }

        public void Saludar() 
        {
            Console.WriteLine("¡Hola!");
        }

        public void SetEdad(int edad)
        {
            Edad = edad;
        }
        public void VerEdad()
        {
            Console.WriteLine("Mi edad es: " + Edad + " años");
        }
    }
}
