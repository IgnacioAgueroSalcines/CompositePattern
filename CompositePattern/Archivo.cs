using System;

namespace Composite
{
    public class Archivo: ElementoConsistente
    {
        public Archivo(string _nombre,int _tamano) : base(_nombre)
        {
            tamano = _tamano;
        }

        public int tamano { get; set; }

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
            return tamano;
        }
        
    }
}
