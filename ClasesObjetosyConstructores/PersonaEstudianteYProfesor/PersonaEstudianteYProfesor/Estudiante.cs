using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaEstudianteYProfesor
{
    internal class Estudiante : Persona
    {
        


        public void Saludar() 
        {
            Console.WriteLine("¡Hola! soy un estudiante");
        }

        public void Estudiar()
        {
           Console.WriteLine("Estoy estudiando");
        }
       
     
    }
}
