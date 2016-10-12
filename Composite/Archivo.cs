using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
     class Archivo: Componente
    {
        public Archivo(string _nombre) : base(_nombre)
        {
        }

        public int tamaño { get; set; }
        public int id { get; set; }

        public override void addComponente(Componente c)
        {
            Console.WriteLine("No se puede añadir porque es una hoja");
        }

        public override void removeComponente(Componente c)
        {
            Console.WriteLine("No se puede borrar porque es una hoja");
        }

        public override int elementos()
        {
            return 1;
        }
    }
}
