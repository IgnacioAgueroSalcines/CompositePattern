using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Composite : Componente
    {
        public List<Componente> componentes { get; set; }
        public int id { get; set; }

        public Composite()
        {
            componentes = new List<Componente>();
        }

        public void addComponente(Componente c)
        {
            componentes.Add(c);
        }

        

        public int elementos()
        {
            int res = 0;
            for (int i = 0; i < componentes.ToArray().Length; i++)
            {
                res += componentes[i].elementos();
            }
            return res;
        }

        public void removeComponente(int id)
        {
            for (int i = 0; i < componentes.ToArray().Length; i++)
            {
               
            }
        }
    }
}
