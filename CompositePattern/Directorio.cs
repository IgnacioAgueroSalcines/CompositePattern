﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
   public class Directorio : Composite
    {
        public int tamano;//medido en Kb

        public Directorio(string _nombre) : base(_nombre)
        {
            tamano = 1;
        }

        public override int getTamano()
        {
            int res = 0;
            for (int i = 0; i < componentes.ToArray().Length; i++)
            {
                res += componentes[i].getTamano();
            }
            return tamano + res;
        }
    }
}
