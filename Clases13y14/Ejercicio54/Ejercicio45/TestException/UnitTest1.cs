using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Ejercicio42;

namespace TestException
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MiClase_MetodoEstatico_DeberiaDevolverDivideByZeroException()
        {
            //arrange

            //act
            MiClase.MetodoEstatico();

            //assert

        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void MiClase_Constructor_DeberiaDevolverUnaExcepcion()
        {
            //arrange
            MiClase oc = new MiClase(true);

            //act

            //assert

        }


        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void OtraClase_MetodoDeInstancia_DeberiaDevolverMiExcepcion()
        {
            //arrange
            OtraClase oc = new OtraClase();

            //act
            oc.metodoInstancia();

            //assert

        }


    }
}
