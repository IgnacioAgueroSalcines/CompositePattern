using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
   public class EnlaceDirecto:Componente
    {
        public int tamano;//medido en Kb
        private ElementoConsistente elemento;

        public EnlaceDirecto(string _nombre,ElementoConsistente e) : base(_nombre)
        {
            tamano = 1;
            this.nombre = e.getNombre();
            elemento = e;
        }

        public EnlaceDirecto(string _nombre, Composite c) : base(_nombre)
        {
            tamano = 1;
            this.nombre = c.getNombre();
        }

        public override void addComponente(Componente c)
        {
            Console.WriteLine("No se puede añadir porque es una hoja");
        }

        public override int elementos()
        {
            Console.WriteLine("No se puede contar elementos porque es un enlace");
            return 0;
        }

        public override void removeComponente(Componente c)
        {
            Console.WriteLine("No se puede borrar porque es una hoja");
        }

        public override void renombrar(string s)
        {
            Console.WriteLine("No se puede renombrar un enlace directo");
        }

        public override string getNombre()
        {
            return this.nombre;
        }

        public override int getTamano()
        {
            return tamano;
        }
    }
}
