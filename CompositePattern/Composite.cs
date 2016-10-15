using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Composite : ElementoConsistente
    {
        private List<Componente> componentes= new List<Componente>();
        private int tamano;

        public Composite(string _nombre) : base(_nombre)
        {
            tamano = 1;
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

        public override void renombrar(string s)
        {
            this.nombre = s;
        }

        public override string getNombre()
        {
            return this.nombre;
        }

        public override int getTamano()
        {
            int res = 0;
            for (int i=0;i<componentes.ToArray().Length;i++)
            {
                res += componentes[i].getTamano();
            }
            return tamano+res;
        }
    }
}
