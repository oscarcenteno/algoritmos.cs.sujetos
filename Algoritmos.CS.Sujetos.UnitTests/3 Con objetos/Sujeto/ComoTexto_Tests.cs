using ConObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.CS.Sujetos.UnitTests.ConObjetos_Tests.Sujeto_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private TipoDeCertificado elTipoDeCertificado;
        private TipoDeIdentificacion elTipoDeIdentificacion;
        private string laIdentificacion;
        private string elNombre;
        private string elPrimerApellido;
        private string elSegundoApellido;

        [TestMethod]
        public void ComoTexto_NoTieneSegundoApellido_NombreYLosApellidosBienFormateados()
        {
            elResultadoEsperado = "CN=JOHN SMITH (AUTENTICACION), OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOHN, Surname=SMITH, SERIALNUMBER=NUP-114145540011";

            laIdentificacion = "114145540011";
            elTipoDeIdentificacion = TipoDeIdentificacion.Didi;
            elTipoDeCertificado = TipoDeCertificado.Autenticacion;
            elNombre = "John";
            elPrimerApellido = "Smith";
            elSegundoApellido = "";
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