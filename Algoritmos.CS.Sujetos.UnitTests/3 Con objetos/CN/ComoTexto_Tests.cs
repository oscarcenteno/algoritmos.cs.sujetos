using ConObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.CS.Sujetos.UnitTests.ConObjetos_Tests.CN_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private string elNombre;
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private TipoDeCertificado elTipo;
        private string losApellidos;

        [TestMethod]
        public void ComoTexto_EsDeAutenticacion_PropositoCorrecto()
        {
            elResultadoEsperado = "CN=MARCELINO NAVARRO QUIROS (AUTENTICACION)";

            elTipo = TipoDeCertificado.Autenticacion;
            elNombre = "MARCELINO";
            losApellidos = "NAVARRO QUIROS";
            elResultadoObtenido = new CN(elTipo, elNombre, losApellidos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_EsDeFirma_PropositoCorrecto()
        {
            elResultadoEsperado = "CN=MARCELINO NAVARRO QUIROS (FIRMA)";

            elTipo = TipoDeCertificado.Firma;
            elNombre = "MARCELINO";
            losApellidos = "NAVARRO QUIROS";
            elResultadoObtenido = new CN(elTipo, elNombre, losApellidos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
