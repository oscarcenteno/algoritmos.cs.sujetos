using ConObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.CS.Sujetos.UnitTests.ConObjetos_Tests.SujetoFormateado_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private TipoDeCertificado elTipoDeCertificado;
        private TipoDeIdentificacion elTipoDeIdentificacion;
        private string laIdentificacion;

        [TestMethod]
        public void ComoTexto_EsNacional_OUYSerialNumberCorrectos()
        {
            elResultadoEsperado = "CN=MARCELINO NAVARRO QUIROS (AUTENTICACION), OU=CIUDADANO, O=PERSONA FISICA, C=CR, GivenName=MARCELINO, Surname=NAVARRO QUIROS, SERIALNUMBER=CPF-01-0078-5935";

            laIdentificacion = "01-0078-5935";
            elTipoDeIdentificacion = TipoDeIdentificacion.Cedula;
            elTipoDeCertificado = TipoDeCertificado.Autenticacion;
            elResultadoObtenido = new SujetoFormateado(laIdentificacion,
                elTipoDeIdentificacion,
                elTipoDeCertificado,
                "MARCELINO",
                "NAVARRO QUIROS").ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_EsExtranjero_OUYSerialNumberCorrectos()
        {
            elResultadoEsperado = "CN=JOSE MIGUEL SUAREZ GODINEZ (AUTENTICACION), OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOSE MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=NUP-114145540011";

            laIdentificacion = "114145540011";
            elTipoDeIdentificacion = TipoDeIdentificacion.Dimex;
            elTipoDeCertificado = TipoDeCertificado.Autenticacion;
            elResultadoObtenido = new SujetoFormateado(laIdentificacion,
                elTipoDeIdentificacion,
                elTipoDeCertificado,
                "JOSE MIGUEL",
                "SUAREZ GODINEZ").ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

    }
}
