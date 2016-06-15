using ConObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.CS.Sujetos.UnitTests.ConObjetos_Tests.ApellidosEnMayusculas_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_DosApellidos_UnidosYEnMayuscula()
        {
            elResultadoEsperado = "GODINEZ SANCHEZ";

            elResultadoObtenido = new ApellidosEnMayusculas("Godinez", "Sanchez").ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
