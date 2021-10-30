using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace TestCentralita
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Centralita_ValidaSiListaLlamadasSeInstancio()
        {
            //Arrange

            Centralita miCentralita = new Centralita("miCentralita");

            //Act

            //Assert
            Assert.IsNotNull(miCentralita.Llamadas);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void Centralita_ValidaSiLocalNoSeRepite()
        {
            //Arrange

            Centralita miCentralita = new Centralita("miCentralita");
            Llamada miLlamada = new Local("080465",2,"911",3);
            Llamada okLlamada = new Local("123", 2, "333", 3);
            Llamada otraLlamada = new Local("080465", 2, "911", 3);

            //Act

            miCentralita += miLlamada;
            miCentralita += okLlamada;
            miCentralita += otraLlamada;

            //Assert

        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void Centralita_ValidaSiLaProvincialNoSeRepite()
        {
            //Arrange

            Centralita miCentralita = new Centralita("miCentralita");
            Provincial miLlamada = new Provincial(Provincial.Franja.Franja_1, "911", 20 , "6380465");
            Provincial okLlamada = new Provincial(Provincial.Franja.Franja_1, "123", 20, "222");
            Provincial otraLlamada = new Provincial(Provincial.Franja.Franja_1, "911", 20, "6380465");
            //Act

            miCentralita += miLlamada;
            miCentralita += okLlamada;
            miCentralita += otraLlamada;

            //Assert

        }


        [TestMethod]
        public void Centralita_()
        {
            //Arrange

            Llamada miLlamada = new Local("080465", 2, "911", 3);
            Llamada otraLlamada = new Local("080465", 2, "911", 3);
            Provincial miLlamadaProv = new Provincial(Provincial.Franja.Franja_1, "911", 20, "6380465");
            Provincial otraLlamadaProv = new Provincial(Provincial.Franja.Franja_1, "911", 20, "6380465");

            //Act


            //Assert
            Assert.AreEqual(miLlamada, otraLlamada);
            Assert.AreEqual(miLlamadaProv, otraLlamadaProv);
            Assert.AreNotEqual(miLlamada, miLlamadaProv);
            Assert.AreNotEqual(otraLlamadaProv, otraLlamada);

        }







    }
}
