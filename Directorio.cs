using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
   public class Directorio : Composite
    {
        public int tamano;//medido en Kb

        public Directorio(string _nombre) : base(_nombre)
        {
            tamano = 1;
        }
        

    }
}
