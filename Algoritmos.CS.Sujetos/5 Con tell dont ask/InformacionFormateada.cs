using System;

namespace ConTellDontAsk
{
    public class InformacionFormateada
    {
        public string ApellidosFormateados { get; set; }
        public string Identificacion { get; set; }
        public string NombreEnMayuscula { get; set; }
        public TipoDeCertificado TipoDeCertificado { get; set; }
        public TipoDeIdentificacion TipoDeIdentificacion { get; set; }

        public bool EsDeAutenticacion()
        {
            return TipoDeCertificado == TipoDeCertificado.Autenticacion;
        }

        public bool EsNacional()
        {
            return TipoDeIdentificacion == TipoDeIdentificacion.Cedula;
        }

        internal string ObtengaSuProposito()
        {
            if (EsDeAutenticacion())
                return ObtengaElPropositoDeAutenticacion();
            else
                return ObtengaElPropositoDeFirma();
        }

        private static string ObtengaElPropositoDeAutenticacion()
        {
            return "AUTENTICACION";
        }

        internal string ObtengaElOU()
        {
            if (EsNacional())
                return ObtengaElOUNacional();
            else
                return ObtengaElOUExtranjero();
        }

        private static string ObtengaElOUNacional()
        {
            return "OU=CIUDADANO";
        }

        private static string ObtengaElOUExtranjero()
        {
            return "OU=EXTRANJERO";
        }

        private static string ObtengaElPropositoDeFirma()
        {
            return "FIRMA";
        }

        public string ObtengaElSerialNumberNacional()
        {
            return $"SERIALNUMBER=CPF-{Identificacion}";
        }

        internal string ObtengaElSerialNumber()
        {
            if (EsNacional())
                return ObtengaElSerialNumberNacional();
            else
                return ObtengaElSerialNumberExtranjero();
        }

        internal string ObtengaElSerialNumberExtranjero()
        {
            return $"SERIALNUMBER=NUP-{Identificacion}";
        }

        public string ObtengaElGivenName()
        {
            return $"GivenName={NombreEnMayuscula}";
        }

        public string ObtengaElSurName()
        {
            return $"Surname={ApellidosFormateados}";
        }
    }
}
