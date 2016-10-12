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
        Componente composite;
        Archivo borrar;

        [TestInitialize()]
        public void startUp()
        {
            borrar = new Archivo("hoja4");
            composite = new Composite("root");
            Componente composite2 = new Composite("dir");
            Componente composite3 = new Composite("comp");


            composite3.addComponente(new Archivo("hoja1"));
            composite3.addComponente(new Archivo("hoja2"));

            composite2.addComponente(new Archivo("hoja3"));
            composite2.addComponente(composite3);

            composite.addComponente(borrar);
            composite.addComponente(composite2);


        }

        [TestMethod()]
        public void addComponenteTest()
        {

            int numeroHojas = composite.elementos() ;

            Assert.AreEqual(4,numeroHojas);
        }

        [TestMethod()]
        public void removeComponenteTest()
        {
            composite.removeComponente(borrar);
            int numeroHojas = composite.elementos();
            Assert.AreEqual(3, numeroHojas);


        }


    }
}