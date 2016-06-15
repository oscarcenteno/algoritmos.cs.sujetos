using ConObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.CS.Sujetos.UnitTests.ConObjetos_Tests.ApellidosFormateados_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_NoTieneSegundoApellido_NoHayEspaciosAlFinal()
        {
            elResultadoEsperado = "GODINEZ";

            elResultadoObtenido = new ApellidosFormateados("Godinez", "").ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
