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
            borrar = new Archivo("hoja4",5);
            composite = new Composite("root");
            Componente composite2 = new Composite("dir");
            Componente composite3 = new Composite("comp");


            composite3.addComponente(new Archivo("hoja1",5));
            composite3.addComponente(new Archivo("hoja2",5));

            composite2.addComponente(new Archivo("hoja3",5));
            composite2.addComponente(composite3);

            EnlaceDirecto e = new EnlaceDirecto("",composite2);

            composite.addComponente(borrar);
            composite.addComponente(composite2);
            composite.addComponente(e);


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

        [TestMethod()]
        public void getTamanoTest()
        {

            int res = composite.getTamano();
            Assert.AreEqual(24, res);


        }


    }
}