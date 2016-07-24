namespace ConTellDontAsk
{
    public class Sujeto
    {
        private InformacionFormateada laInformacionFormateada;

        public Sujeto(InformacionDelSolicitante laInformacion)
        {
            laInformacionFormateada = new InformacionFormateada();
            laInformacionFormateada.NombreEnMayuscula = ObtengaElNombreEnMayuscula(laInformacion);
            laInformacionFormateada.ApellidosFormateados = ObtengaLosApellidosFormateados(laInformacion);
            // TODO: Arreglar estos detalles
            laInformacionFormateada.TipoDeCertificado = laInformacion.TipoDeCertificado;
            laInformacionFormateada.TipoDeIdentificacion = laInformacion.TipoDeIdentificacion;
            laInformacionFormateada.Identificacion = laInformacion.Identificacion;
        }

        private static string ObtengaElNombreEnMayuscula(InformacionDelSolicitante laInformacion)
        {
            return laInformacion.NombreEnMayusculas;
        }

        private static string ObtengaLosApellidosFormateados(InformacionDelSolicitante laInformacion)
        {
            return new ApellidosFormateados(laInformacion).ComoTexto();
        }

        public string ComoTexto()
        {
            return new SujetoFormateado(laInformacionFormateada).ComoTexto();
        }
    }
}