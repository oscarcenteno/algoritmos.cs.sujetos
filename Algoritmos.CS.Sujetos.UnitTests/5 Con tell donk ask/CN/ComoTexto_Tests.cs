using ConTellDontAsk;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.CS.Sujetos.UnitTests.ConTellDontAsk.CN_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private InformacionFormateada laInformacion;

        [TestMethod]
        public void ComoTexto_EsDeAutenticacion_PropositoCorrecto()
        {
            elResultadoEsperado = "CN=MARCELINO NAVARRO QUIROS (AUTENTICACION)";

            laInformacion = new InformacionFormateada();
            laInformacion.TipoDeCertificado = TipoDeCertificado.Autenticacion;
            laInformacion.NombreEnMayuscula = "MARCELINO";
            laInformacion.ApellidosFormateados = "NAVARRO QUIROS";
            elResultadoObtenido = new CN(laInformacion).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_EsDeFirma_PropositoCorrecto()
        {
            elResultadoEsperado = "CN=MARCELINO NAVARRO QUIROS (FIRMA)";

            laInformacion = new InformacionFormateada();
            laInformacion.TipoDeCertificado = TipoDeCertificado.Firma;
            laInformacion.NombreEnMayuscula = "MARCELINO";
            laInformacion.ApellidosFormateados = "NAVARRO QUIROS";
            elResultadoObtenido = new CN(laInformacion).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}