using ConPolimorfismo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.CS.Sujetos.UnitTests.ConPolimorfismo.ApellidosEnMayusculas_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private InformacionDelSolicitante laInformacion;

        [TestMethod]
        public void ComoTexto_DosApellidos_UnidosYEnMayuscula()
        {
            elResultadoEsperado = "GODINEZ SANCHEZ";

            InicialiceLaInformacion();
            elResultadoObtenido = new ApellidosEnMayusculas(laInformacion).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceLaInformacion()
        {
            laInformacion = new InformacionDelSolicitante();
            laInformacion.PrimerApellido = "Godinez";
            laInformacion.SegundoApellido = "Sanchez";
        }
    }
}
