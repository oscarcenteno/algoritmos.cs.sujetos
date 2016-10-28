using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetos;

namespace Algoritmos.CS.Sujetos.UnitTests.ConObjetos_Tests
{
    [TestClass]
    public class GenereUnSujeto_Tests
    {
        private string elNombre;
        private string elPrimerApellido;
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private string elSegundoApellido;
        private TipoDeIdentificacion elTipoDeIdentificacion;
        private TipoDeCertificado elTipoDeCertificado;
        private string laIdentificacion;

        [TestMethod]
        public void GenereUnSujeto_AutenticacionParaUnaPersonaNacional_PropósitoOUYSerialCorrectos()
        {
            elResultadoEsperado = "CN=MARCELINO NAVARRO QUIROS (AUTENTICACION), OU=CIUDADANO, O=PERSONA FISICA, C=CR, GivenName=MARCELINO, Surname=NAVARRO QUIROS, SERIALNUMBER=CPF-01-0078-5935";

            laIdentificacion = "01-0078-5935";
            elTipoDeIdentificacion = TipoDeIdentificacion.Cedula;
            elNombre = "Marcelino";
            elPrimerApellido = "Navarro";
            elSegundoApellido = "Quiros";
            elTipoDeCertificado = TipoDeCertificado.Autenticacion;
            elResultadoObtenido = new Sujeto(laIdentificacion,
                elTipoDeIdentificacion,
                elNombre,
                elPrimerApellido,
                elSegundoApellido,
                elTipoDeCertificado
                ).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereUnSujeto_FirmaParaUnaPersonaNacional_PropósitoOUYSerialCorrectos()
        {
            elResultadoEsperado = "CN=MARCELINO NAVARRO QUIROS (FIRMA), OU=CIUDADANO, O=PERSONA FISICA, C=CR, GivenName=MARCELINO, Surname=NAVARRO QUIROS, SERIALNUMBER=CPF-01-0078-5935";

            laIdentificacion = "01-0078-5935";
            elTipoDeIdentificacion = TipoDeIdentificacion.Cedula;
            elNombre = "Marcelino";
            elPrimerApellido = "Navarro";
            elSegundoApellido = "Quiros";
            elTipoDeCertificado = TipoDeCertificado.Firma;
            elResultadoObtenido = new Sujeto(laIdentificacion,
                elTipoDeIdentificacion,
                elNombre,
                elPrimerApellido,
                elSegundoApellido,
                elTipoDeCertificado
                ).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereUnSujeto_AutenticacionParaUnaPersonaExtranjera_PropósitoOUYSerialCorrectos()
        {
            elResultadoEsperado = "CN=JOSE MIGUEL SUAREZ GODINEZ (AUTENTICACION), OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOSE MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=NUP-114145540011";

            laIdentificacion = "114145540011";
            elTipoDeIdentificacion = TipoDeIdentificacion.Dimex;
            elNombre = "Jose Miguel";
            elPrimerApellido = "Suarez";
            elSegundoApellido = "Godinez";
            elTipoDeCertificado = TipoDeCertificado.Autenticacion;
            elResultadoObtenido = new Sujeto(laIdentificacion,
                elTipoDeIdentificacion,
                elNombre,
                elPrimerApellido,
                elSegundoApellido,
                elTipoDeCertificado
                ).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereUnSujeto_FirmaaraUnaPersonaExtranjera_PropósitoOUYSerialCorrectos()
        {
            elResultadoEsperado = "CN=JOSE MIGUEL SUAREZ GODINEZ (FIRMA), OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOSE MIGUEL, Surname=SUAREZ GODINEZ, SERIALNUMBER=NUP-114145540011";

            laIdentificacion = "114145540011";
            elTipoDeIdentificacion = TipoDeIdentificacion.Dimex;
            elNombre = "Jose Miguel";
            elPrimerApellido = "Suarez";
            elSegundoApellido = "Godinez";
            elTipoDeCertificado = TipoDeCertificado.Firma;
            elResultadoObtenido = new Sujeto(laIdentificacion,
                elTipoDeIdentificacion,
                elNombre,
                elPrimerApellido,
                elSegundoApellido,
                elTipoDeCertificado
                ).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereUnSujeto_AutenticacionParaUnaPersonaExtranjeraConUnSoloApellido_ApellidosBienFormateados()
        {
            elResultadoEsperado = "CN=JOHN SMITH (AUTENTICACION), OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOHN, Surname=SMITH, SERIALNUMBER=NUP-114145540011";

            laIdentificacion = "114145540011";
            elTipoDeIdentificacion = TipoDeIdentificacion.Didi;
            elNombre = "John";
            elPrimerApellido = "Smith";
            elSegundoApellido = "";
            elTipoDeCertificado = TipoDeCertificado.Autenticacion;
            elResultadoObtenido = new Sujeto(laIdentificacion,
                elTipoDeIdentificacion,
                elNombre,
                elPrimerApellido,
                elSegundoApellido,
                elTipoDeCertificado
                ).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereUnSujeto_FirmaParaUnaPersonaExtranjeraConUnSoloApellido_ApellidosBienFormateados()
        {
            elResultadoEsperado = "CN=JOHN SMITH (FIRMA), OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOHN, Surname=SMITH, SERIALNUMBER=NUP-114145540011";

            laIdentificacion = "114145540011";
            elTipoDeIdentificacion = TipoDeIdentificacion.Didi;
            elNombre = "John";
            elPrimerApellido = "Smith";
            elSegundoApellido = "";
            elTipoDeCertificado = TipoDeCertificado.Firma;
            elResultadoObtenido = new Sujeto(laIdentificacion,
                elTipoDeIdentificacion,
                elNombre,
                elPrimerApellido,
                elSegundoApellido,
                elTipoDeCertificado
                ).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}