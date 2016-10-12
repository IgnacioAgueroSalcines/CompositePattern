using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public interface Componente
    {
        void addComponente(Componente c);
        void removeComponente(int id);
        int elementos();
    }
}
