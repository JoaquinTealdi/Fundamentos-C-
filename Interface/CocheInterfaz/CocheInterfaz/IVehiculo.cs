using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocheInterfaz
{
    internal interface IVehiculo
    {
        public void Conducir() 
        {
        }

        public bool Repostar(int cantidad)
        {
            return false;
        }
    }
}
