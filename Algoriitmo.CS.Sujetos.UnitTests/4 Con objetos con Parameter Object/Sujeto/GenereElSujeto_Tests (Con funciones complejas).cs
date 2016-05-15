using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sujeto;

/*
Este código siguiente se presenta para compararlo con la otra clase GenereElSujeto_Tests
en donde cada prueba unitaria y cada función tiene una responsabilidad única.
El beneficio de las funciones se vive cuando hay un defecto 
o hay que entender la lógica de un proceso.
*/

public class GenereElSujeto_Tests_ConFuncionesComplejas
{
    private string elResultadoEsperado;
    private string elResultadoObtenido;
    private Solicitante elSolicitante;
    private GeneracionDeSujetos elGenerador;

    [TestInitialize()]
    public void Inicialice()
    {
        elSolicitante = new Solicitante();
        elGenerador = new GeneracionDeSujetos();
    }

    [TestMethod()]
    public void GenereElSujeto_DeAutenticacionParaUnNacional()
    {
        elResultadoEsperado = "CN=MARCELINO NAVARRO QUIROS (AUTENTICACION)," + 
            " OU=CIUDADANO, O=PERSONA FISICA, C=CR, GivenName=MARCELINO," + 
            " Surname=NAVARRO QUIROS, SERIALNUMBER=CPF-01-0078-5935";

        elSolicitante.Identificacion = "01-0078-5935";
        elSolicitante.TipoDeIdentificacion = TipoDeIdentificacion.Cedula;
        elSolicitante.Nombre = "Marcelino";
        elSolicitante.PrimerApellido = "Navarro";
        elSolicitante.SegundoApellido = "Quiros";
        TipoDeCertificado elTipo = TipoDeCertificado.DeAutenticacion;
        elResultadoObtenido = GeneracionDeSujetos.GenereElSujeto(elSolicitante, elTipo);

        Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
    }

    [TestMethod()]
    public void GenereElSujeto_DeFirmaParaUnNacional()
    {
        elResultadoEsperado = "CN=MARCELINO NAVARRO QUIROS (FIRMA)," + 
            " OU=CIUDADANO, O=PERSONA FISICA, C=CR, GivenName=MARCELINO," + 
            " Surname=NAVARRO QUIROS, SERIALNUMBER=CPF-01-0078-5935";

        elSolicitante.Identificacion = "01-0078-5935";
        elSolicitante.TipoDeIdentificacion = TipoDeIdentificacion.Cedula;
        elSolicitante.Nombre = "Marcelino";
        elSolicitante.PrimerApellido = "Navarro";
        elSolicitante.SegundoApellido = "Quiros";
        TipoDeCertificado elTipo = TipoDeCertificado.DeFirma;
        elResultadoObtenido = GeneracionDeSujetos.GenereElSujeto(elSolicitante, elTipo);

        Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
    }

    [TestMethod()]
    public void GenereElSujeto_DeFirmaParaUnExtranjero()
    {
        elResultadoEsperado = "CN=JOSE MIGUEL SUAREZ GODINEZ (FIRMA)," + 
            " OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOSE MIGUEL," + 
            " Surname=SUAREZ GODINEZ, SERIALNUMBER=NUP-114145540011";

        elSolicitante.Identificacion = "114145540011";
        elSolicitante.TipoDeIdentificacion = TipoDeIdentificacion.Dimex;
        elSolicitante.Nombre = "Jose Miguel";
        elSolicitante.PrimerApellido = "Suarez";
        elSolicitante.SegundoApellido = "Godinez";
        TipoDeCertificado elTipo = TipoDeCertificado.DeFirma;
        elResultadoObtenido = elGenerador.GenereElSujeto(elSolicitante, elTipo);
        Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
    }

    [TestMethod()]
    public void GenereElSujeto_DeAutenticacionParaUnExtranjero()
    {
        elResultadoEsperado = "CN=JOSE MIGUEL SUAREZ GODINEZ (AUTENTICACION)," +
            " OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOSE MIGUEL," +
            " Surname=SUAREZ GODINEZ, SERIALNUMBER=NUP-114145540011";

        elSolicitante.Identificacion = "114145540011";
        elSolicitante.TipoDeIdentificacion = TipoDeIdentificacion.Dimex;
        elSolicitante.Nombre = "Jose Miguel";
        elSolicitante.PrimerApellido = "Suarez";
        elSolicitante.SegundoApellido = "Godinez";
        TipoDeCertificado elTipo = TipoDeCertificado.DeAutenticacion;
        elResultadoObtenido = elGenerador.GenereElSujeto(elSolicitante, elTipo);

        Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
    }

    [TestMethod()]
    public void GenereElSujeto_DeAutenticacionParaUnExtranjeroConUnSoloApellido()
    {
        elResultadoEsperado = "CN=JOHN SMITH (AUTENTICACION)," + 
            " OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOHN," + 
            " Surname=SMITH, SERIALNUMBER=NUP-500000000035";

        elSolicitante.Identificacion = "500000000035";
        elSolicitante.TipoDeIdentificacion = TipoDeIdentificacion.Didi;
        elSolicitante.Nombre = "John";
        elSolicitante.PrimerApellido = "Smith";
        elSolicitante.SegundoApellido = "";
        TipoDeCertificado elTipo = TipoDeCertificado.DeAutenticacion;
        elResultadoObtenido = elGenerador.GenereElSujeto(elSolicitante, elTipo);

        Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
    }

    [TestMethod()]
    public void GenereElSujeto_DeFirmaParaUnExtranjeroConUnSoloApellido()
    {
        elResultadoEsperado = "CN=JOHN SMITH (FIRMA)," + 
            " OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOHN," + 
            " Surname=SMITH, SERIALNUMBER=NUP-500000000035";

        elSolicitante.Identificacion = "500000000035";
        elSolicitante.TipoDeIdentificacion = TipoDeIdentificacion.Didi;
        elSolicitante.Nombre = "John";
        elSolicitante.PrimerApellido = "Smith";
        elSolicitante.SegundoApellido = "";
        TipoDeCertificado elTipo = TipoDeCertificado.DeFirma;
        elResultadoObtenido = elGenerador.GenereElSujeto(elSolicitante, elTipo);

        Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
    }
}
