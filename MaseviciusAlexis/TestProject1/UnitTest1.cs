using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Archivos_ValidarsiGuardarCoincideConLeer()
        {

           //Arrange
            JsonFiler<string> json = new JsonFiler<string>();
            string miString = "12345";
            string otroString;


            //Act
            json.Guardar("archivo.txt", miString);
            json.Leer("archivo.txt", out otroString);

            //Assert
            Assert.AreEqual(miString, otroString);

        }


        [TestMethod]
        [ExpectedException(typeof(ErrorArchivosException))]
        public void Archivos_IntentaGuardarEnRutaInvalida()
        {
            //Arrange
            JsonFiler<Juego> json = new JsonFiler<Juego>();
            Juego mijuego = new Juego(10, "lalala");


            //Act
            json.Guardar("////////   ", mijuego);

            //Assert

        }

    }
}
