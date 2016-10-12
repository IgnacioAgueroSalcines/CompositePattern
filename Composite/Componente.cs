using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class Componente
    {
        protected String nombre;

        public Componente(String _nombre)
        {
            nombre = _nombre;
        }

        public abstract void addComponente(Componente c);
        public abstract void removeComponente(Componente c);
        public abstract int elementos();
}
}
