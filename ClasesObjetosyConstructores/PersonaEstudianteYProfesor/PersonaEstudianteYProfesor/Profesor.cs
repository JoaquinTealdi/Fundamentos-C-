using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaEstudianteYProfesor
{
    internal class Profesor : Persona 
    {


        public void Saludar()
        {
            Console.WriteLine("¡Hola! soy un profesor");
        }
        public void Explicar() 
        {
            Console.WriteLine("Estoy explicando");
        }
    }
}
