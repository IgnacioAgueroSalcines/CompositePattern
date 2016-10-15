using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
     public class Comprimido : Composite
    {
        public Comprimido(string _nombre) : base(_nombre)
        {
        }

        public override int getTamano()
        {
            double res = 0;
            for (int i = 0; i < base.componentes.ToArray().Length; i++)
            {
                res += base.componentes[i].getTamano();
            }
            int result=(int)Math.Round(res*0.3, 0);
            return result;
        }
    }
}
