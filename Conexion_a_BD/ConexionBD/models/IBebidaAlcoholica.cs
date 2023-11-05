using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public interface IBebidaAlcoholica
    {
        public int alcohol { get; set; }

        public void MaximoRecomendado();
    }
}
