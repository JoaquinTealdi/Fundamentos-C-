using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocheInterfaz
{
    internal class Coche : IVehiculo
    {
        private int CantGasolina { get; set; }

        public Coche(int gasolina) 
        {
            CantGasolina = gasolina;
        }

        public void Conducir()
        {
            Console.WriteLine("Conduciendo");
        }

        public bool Repostar(int cantidad)
        {
            if (CantGasolina > 0) 
            {
                CantGasolina += cantidad;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GetGasolina() 
        {
            Console.WriteLine("La cantidad de gasolina del coche es {0}", CantGasolina);        
        }


    }
}
