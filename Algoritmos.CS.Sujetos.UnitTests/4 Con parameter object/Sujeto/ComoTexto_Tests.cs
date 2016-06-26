using ConParameterObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.CS.Sujetos.UnitTests.ConParameterObject_Tests.Sujeto_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private InformacionDelSolicitante laInformacion;

        [TestMethod]
        public void ComoTexto_NoTieneSegundoApellido_NombreYLosApellidosBienFormateados()
        {
            elResultadoEsperado = "CN=JOHN SMITH (AUTENTICACION), OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOHN, Surname=SMITH, SERIALNUMBER=NUP-114145540011";

            laInformacion = new InformacionDelSolicitante();
            laInformacion.Identificacion = "114145540011";
            laInformacion.TipoDeIdentificacion = TipoDeIdentificacion.Didi;
            laInformacion.TipoDeCertificado = TipoDeCertificado.Autenticacion;
            laInformacion.Nombre = "John";
            laInformacion.PrimerApellido = "Smith";
            laInformacion.SegundoApellido = "";
            elResultadoObtenido = new Sujeto(laInformacion).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}