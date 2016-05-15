using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetosTellDontAsk;

namespace ConObjetosTellDontAsk_Tests
{
    [TestClass()]
    public class Formateado_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private Solicitante elSolicitante;
        private TipoDeCertificado elTipoDeCertificado;

        [TestInitialize]
        public void Inicialice()
        {
            elSolicitante = new Solicitante();
        }


        [TestMethod()]
        public void Formateado_DeAutenticacionParaUnNacional()
        {
            elResultadoEsperado = Escenarios.UnSujetoDeAutenticacionParaUnNacional();

            InicialiceDeAutenticacionParaUnNacional();
            elResultadoObtenido = new Sujeto(elSolicitante, elTipoDeCertificado).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceDeAutenticacionParaUnNacional()
        {
            AsigneUnNacional();
            AsigneElTipoDeAutenticacion();
        }

        private void AsigneUnNacional()
        {
            AsigneUnaIdentificacioNacional();
            AsigneUnNombreNacional();
        }

        private void AsigneUnaIdentificacioNacional()
        {
            elSolicitante.Identificacion = "01-0078-5935";
            elSolicitante.TipoDeIdentificacion = TipoDeIdentificacion.Cedula;
        }

        private void AsigneUnNombreNacional()
        {
            elSolicitante.Nombre = "Marcelino";
            elSolicitante.PrimerApellido = "Navarro";
            elSolicitante.SegundoApellido = "Quiros";
        }

        private void AsigneElTipoDeAutenticacion()
        {
            elTipoDeCertificado = TipoDeCertificado.DeAutenticacion;
        }

        [TestMethod()]
        public void Formateado_DeFirmaParaUnNacional()
        {
            elResultadoEsperado = Escenarios.UnSujetoDeFirmaParaUnNacional();

            InicialiceDeFirmaParaUnNacional();
            elResultadoObtenido = new Sujeto(elSolicitante, elTipoDeCertificado).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceDeFirmaParaUnNacional()
        {
            AsigneUnNacional();
            AsigneElTipoDeFirma();
        }

        private void AsigneElTipoDeFirma()
        {
            elTipoDeCertificado = TipoDeCertificado.DeFirma;
        }

        [TestMethod()]
        public void Formateado_DeFirmaParaUnExtranjero()
        {
            elResultadoEsperado = Escenarios.UnSujetoDeFirmaParaUnExtranjero();

            InicialiceDeFirmaParaUnExtranjero();
            elResultadoObtenido = new Sujeto(elSolicitante, elTipoDeCertificado).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceDeFirmaParaUnExtranjero()
        {
            AsigneUnExtranjero();
            AsigneElTipoDeFirma();
        }

        private void AsigneUnExtranjero()
        {
            AsigneUnaIdentificacionExtranjera();
            AsigneUnNombreExtranjero();
        }

        private void AsigneUnaIdentificacionExtranjera()
        {
            elSolicitante.Identificacion = "114145540011";
            elSolicitante.TipoDeIdentificacion = TipoDeIdentificacion.Dimex;
        }

        private void AsigneUnNombreExtranjero()
        {
            elSolicitante.Nombre = "Jose Miguel";
            elSolicitante.PrimerApellido = "Suarez";
            elSolicitante.SegundoApellido = "Godinez";
        }

        [TestMethod()]
        public void Formateado_DeAutenticacionParaUnExtranjero()
        {
            elResultadoEsperado = Escenarios.UnSujetoDeAutenticacionParaUnExtranjero();

            InicialiceDeAutenticacionParaUnExtranjero();
            elResultadoObtenido = new Sujeto(elSolicitante, elTipoDeCertificado).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceDeAutenticacionParaUnExtranjero()
        {
            AsigneUnExtranjero();
            AsigneElTipoDeAutenticacion();
        }

        [TestMethod()]
        public void Formateado_DeAutenticacionParaUnExtranjeroConUnSoloApellido()
        {
            elResultadoEsperado = Escenarios.UnSujetoDeAutenticacionParaUnExtranjeroConUnSoloApellido();

            InicialiceDeAutenticacionParaUnExtranjeroConUnSoloApellido();
            elResultadoObtenido = new Sujeto(elSolicitante, elTipoDeCertificado).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceDeAutenticacionParaUnExtranjeroConUnSoloApellido()
        {
            AsigneUnExtranjeroConUnSoloApellido();
            AsigneElTipoDeAutenticacion();
        }

        private void AsigneUnExtranjeroConUnSoloApellido()
        {
            AsigneUnaIdentificacionExtranjera();
            AsigneUnNombreExtranjeroConUnSoloApellido();
        }

        private void AsigneUnNombreExtranjeroConUnSoloApellido()
        {
            elSolicitante.Nombre = "John";
            elSolicitante.PrimerApellido = "Smith";
            elSolicitante.SegundoApellido = "";
        }

        [TestMethod()]
        public void Formateado_DeFirmaParaUnExtranjeroConUnSoloApellido()
        {
            elResultadoEsperado = Escenarios.UnSujetoDeFirmaParaUnExtranjeroConUnSoloApellido();

            InicialiceDeFirmaParaUnExtranjeroConUnSoloApellido();
            elResultadoObtenido = new Sujeto(elSolicitante, elTipoDeCertificado).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceDeFirmaParaUnExtranjeroConUnSoloApellido()
        {
            AsigneUnExtranjeroConUnSoloApellido();
            AsigneElTipoDeFirma();
        }
    }
}