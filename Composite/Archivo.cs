using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Archivo: Componente
    {
        public String nombre { get; set; }
        public int tamaño { get; set; }
        public int id { get; set; }

        public void addComponente(Componente c)
        {
            throw new NotImplementedException();
        }

        public int elementos()
        {
            return 1;
        }

        public void removeComponente(int id)
        {
            throw new NotImplementedException();
        }
    }
}
