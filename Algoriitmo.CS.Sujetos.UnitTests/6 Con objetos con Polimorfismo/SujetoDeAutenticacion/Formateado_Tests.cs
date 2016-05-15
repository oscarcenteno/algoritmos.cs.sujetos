using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetosConPolimorfismo;

namespace ConObjetosConPolimorfismo_Tests.SujetoDeAutenticacion_Tests
{
    [TestClass()]
    public class Formateado_Tests: EscenarioBase_Tests
    {
        [TestMethod()]
        public void Formateado_DeAutenticacionParaUnNacional()
        {
            elResultadoEsperado = Escenarios.UnSujetoDeAutenticacionParaUnNacional();

            InicialiceUnNacional();
            elResultadoObtenido = new SujetoDeAutenticacion(elSolicitante).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void Formateado_DeAutenticacionParaUnExtranjero()
        {
            elResultadoEsperado = Escenarios.UnSujetoDeAutenticacionParaUnExtranjero();

            InicialiceUnExtranjero();
            elResultadoObtenido = new SujetoDeAutenticacion(elSolicitante).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void Formateado_DeAutenticacionParaUnExtranjeroConUnSoloApellido()
        {
            elResultadoEsperado = Escenarios.UnSujetoDeAutenticacionParaUnExtranjeroConUnSoloApellido();

            InicialiceUnExtranjeroConUnSoloApellido();
            elResultadoObtenido = new SujetoDeAutenticacion(elSolicitante).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}