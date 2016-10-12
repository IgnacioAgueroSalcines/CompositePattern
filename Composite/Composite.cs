using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
     class Composite : Componente
    {
        private List<Componente> componentes= new List<Componente>();

        public Composite(string _nombre) : base(_nombre)
        {
        }

        public override void addComponente(Componente c)
        {
            componentes.Add(c);
        }

        public override void removeComponente(Componente c)
        {
            componentes.Remove(c);
        }

        public override int elementos()
        {
            int res = 0;
            for (int i = 0; i < componentes.ToArray().Length; i++)
            {
                res += componentes[i].elementos();
            }
            return res;
        }
    }
}
