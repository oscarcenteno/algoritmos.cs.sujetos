using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConFunciones;

namespace ConFunciones_Tests
{
    [TestClass()]
    public class GenereElSujeto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private string laIdentificacion;
        private TipoDeIdentificacion elTipoDeIdentificacion;
        private string elNombre;
        private string elPrimerApellido;
        private string elSegundoApellido;
        private TipoDeCertificado elTipoDeCertificado;

        [TestMethod()]
        public void GenereElSujeto_DeAutenticacionParaUnNacional()
        {
            elResultadoEsperado = Escenarios.UnSujetoDeAutenticacionParaUnNacional();

            InicialiceDeAutenticacionParaUnNacional();
            elResultadoObtenido = GeneracionDeSujetos.GenereElSujeto(laIdentificacion,
                elNombre,
                elPrimerApellido,
                elSegundoApellido,
                elTipoDeIdentificacion,
                elTipoDeCertificado);

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
            laIdentificacion = "01-0078-5935";
            elTipoDeIdentificacion = TipoDeIdentificacion.Cedula;
        }

        private void AsigneUnNombreNacional()
        {
            elNombre = "Marcelino";
            elPrimerApellido = "Navarro";
            elSegundoApellido = "Quiros";
        }

        private void AsigneElTipoDeAutenticacion()
        {
            elTipoDeCertificado = TipoDeCertificado.DeAutenticacion;
        }

        [TestMethod()]
        public void GenereElSujeto_DeFirmaParaUnNacional()
        {
            elResultadoEsperado = Escenarios.UnSujetoDeFirmaParaUnNacional();

            InicialiceDeFirmaParaUnNacional();
            elResultadoObtenido = GeneracionDeSujetos.GenereElSujeto(laIdentificacion,
                elNombre,
                elPrimerApellido,
                elSegundoApellido,
                elTipoDeIdentificacion,
                elTipoDeCertificado);

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
        public void GenereElSujeto_DeFirmaParaUnExtranjero()
        {
            elResultadoEsperado = Escenarios.UnSujetoDeFirmaParaUnExtranjero();

            InicialiceDeFirmaParaUnExtranjero();
            elResultadoObtenido = GeneracionDeSujetos.GenereElSujeto(laIdentificacion,
                elNombre,
                elPrimerApellido,
                elSegundoApellido,
                elTipoDeIdentificacion,
                elTipoDeCertificado);

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
            laIdentificacion = "114145540011";
            elTipoDeIdentificacion = TipoDeIdentificacion.Dimex;
        }

        private void AsigneUnNombreExtranjero()
        {
            elNombre = "Jose Miguel";
            elPrimerApellido = "Suarez";
            elSegundoApellido = "Godinez";
        }

        [TestMethod()]
        public void GenereElSujeto_DeAutenticacionParaUnExtranjero()
        {
            elResultadoEsperado = Escenarios.UnSujetoDeAutenticacionParaUnExtranjero();

            InicialiceDeAutenticacionParaUnExtranjero();
            elResultadoObtenido = GeneracionDeSujetos.GenereElSujeto(laIdentificacion,
                elNombre,
                elPrimerApellido,
                elSegundoApellido,
                elTipoDeIdentificacion,
                elTipoDeCertificado);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceDeAutenticacionParaUnExtranjero()
        {
            AsigneUnExtranjero();
            AsigneElTipoDeAutenticacion();
        }

        [TestMethod()]
        public void GenereElSujeto_DeAutenticacionParaUnExtranjeroConUnSoloApellido()
        {
            elResultadoEsperado = Escenarios.UnSujetoDeAutenticacionParaUnExtranjeroConUnSoloApellido();

            InicialiceDeAutenticacionParaUnExtranjeroConUnSoloApellido();
            elResultadoObtenido = GeneracionDeSujetos.GenereElSujeto(laIdentificacion,
                elNombre,
                elPrimerApellido,
                elSegundoApellido,
                elTipoDeIdentificacion,
                elTipoDeCertificado);

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
            elNombre = "John";
            elPrimerApellido = "Smith";
            elSegundoApellido = "";
        }

        [TestMethod()]
        public void GenereElSujeto_DeFirmaParaUnExtranjeroConUnSoloApellido()
        {
            elResultadoEsperado = Escenarios.UnSujetoDeFirmaParaUnExtranjeroConUnSoloApellido();

            InicialiceDeFirmaParaUnExtranjeroConUnSoloApellido();
            elResultadoObtenido = GeneracionDeSujetos.GenereElSujeto(laIdentificacion,
                elNombre,
                elPrimerApellido,
                elSegundoApellido,
                elTipoDeIdentificacion,
                elTipoDeCertificado);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceDeFirmaParaUnExtranjeroConUnSoloApellido()
        {
            AsigneUnExtranjeroConUnSoloApellido();
            AsigneElTipoDeFirma();
        }
    }
}