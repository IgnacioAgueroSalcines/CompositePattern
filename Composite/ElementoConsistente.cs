using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class ElementoConsistente : Componente
    {
        public ElementoConsistente(string _nombre) : base(_nombre)
        {
        }
    }
}
