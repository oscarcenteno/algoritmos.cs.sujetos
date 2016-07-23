using ConTellDontAsk;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.CS.Sujetos.UnitTests.ConTellDontAsk_Tests.SujetoFormateado_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private InformacionFormateada laInformacion;

        [TestMethod]
        public void ComoTexto_EsNacional_OUYSerialNumberCorrectos()
        {
            elResultadoEsperado = "CN=MARCELINO NAVARRO QUIROS (AUTENTICACION), OU=CIUDADANO, O=PERSONA FISICA, C=CR, GivenName=MARCELINO, Surname=NAVARRO QUIROS, SERIALNUMBER=CPF-01-0078-5935";

            laInformacion = new InformacionFormateada();
            laInformacion.Identificacion = "01-0078-5935";
            laInformacion.TipoDeIdentificacion = TipoDeIdentificacion.Cedula;
            laInformacion.TipoDeCertificado = TipoDeCertificado.Autenticacion;
            laInformacion.NombreEnMayuscula = "MARCELINO";
            laInformacion.ApellidosFormateados = "NAVARRO QUIROS";
            elResultadoObtenido = new SujetoFormateado(laInformacion).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_EsExtranjero_OUYSerialNumberCorrectos()
        {
            elResultadoEsperado = "CN=JOSE MIGUEL SUAREZ GODINEZ (AUTENTICACION), OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOSE MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=NUP-114145540011";

            laInformacion = new InformacionFormateada();
            laInformacion.Identificacion = "114145540011";
            laInformacion.TipoDeIdentificacion = TipoDeIdentificacion.Dimex;
            laInformacion.TipoDeCertificado = TipoDeCertificado.Autenticacion;
            laInformacion.NombreEnMayuscula = "JOSE MIGUEL";
            laInformacion.ApellidosFormateados = "SUAREZ GODINEZ";
            elResultadoObtenido = new SujetoFormateado(laInformacion).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}