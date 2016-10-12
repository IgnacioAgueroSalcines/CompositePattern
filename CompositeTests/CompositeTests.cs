using Microsoft.VisualStudio.TestTools.UnitTesting;
using Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Tests
{
    [TestClass()]
    public class CompositeTests
    {
        [TestMethod()]
        public void addComponenteTest()
        {

            Componente composite = new Composite();
            Componente composite2 = new Composite();
            Componente composite3 = new Composite();


            composite3.addComponente(new Archivo());
            composite3.addComponente(new Archivo());

            composite2.addComponente(new Archivo());
            composite2.addComponente(composite3);

            composite.addComponente(new Archivo());
            composite.addComponente(composite2);

            int numeroHojas = composite.elementos() ;

            Assert.AreEqual(4,numeroHojas);
            

            


        }
    }
}