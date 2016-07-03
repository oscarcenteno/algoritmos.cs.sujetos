using System;

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
            laInformacionFormateada.TipoDeCertificado = ObtengaElTipoDeCerificado(laInformacion);
            laInformacionFormateada.TipoDeIdentificacion = ObtengaElTipoDeIdentificacion(laInformacion);
            laInformacionFormateada.Identificacion = ObtengaLaIdentificacion(laInformacion);
        }

        private string ObtengaLaIdentificacion(InformacionDelSolicitante laInformacion)
        {
            return laInformacion.Identificacion;
        }

        private TipoDeIdentificacion ObtengaElTipoDeIdentificacion(InformacionDelSolicitante laInformacion)
        {
            return laInformacion.TipoDeIdentificacion; 
        }

        private TipoDeCertificado ObtengaElTipoDeCerificado(InformacionDelSolicitante laInformacion)
        {
            return laInformacion.TipoDeCertificado;
        }

        private static string ObtengaElNombreEnMayuscula(InformacionDelSolicitante laInformacion)
        {
            return laInformacion.NombreEnMayuscula;
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