using System;

namespace ConPolimorfismo
{
    public class InformacionFormateada
    {
        public string ApellidosFormateados { get; set; }
        public string Identificacion { get; set; }
        public string NombreEnMayuscula { get; set; }
        public TipoDeCertificado TipoDeCertificado { get; set; }
        public TipoDeIdentificacion TipoDeIdentificacion { get; set; }

        public string Proposito
        {
            get
            {
                if (EsDeAutenticacion())
                    return ObtengaElPropositoDeAutenticacion();
                else
                    return ObtengaElPropositoDeFirma();
            }
        }

        private bool EsDeAutenticacion()
        {
            return TipoDeCertificado == TipoDeCertificado.Autenticacion;
        }

        private static string ObtengaElPropositoDeAutenticacion()
        {
            return "AUTENTICACION";
        }

        public string OU
        {
            get
            {
                if (EsNacional())
                    return ObtengaElOUNacional();
                else
                    return ObtengaElOUExtranjero();
            }
        }

        private bool EsNacional()
        {
            return TipoDeIdentificacion == TipoDeIdentificacion.Cedula;
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

        public string SerialNumber
        {
            get
            {
                if (EsNacional())
                    return ObtengaElSerialNumberNacional();
                else
                    return ObtengaElSerialNumberExtranjero();
            }
        }

        private string ObtengaElSerialNumberNacional()
        {
            return $"SERIALNUMBER=CPF-{Identificacion}";
        }

        private string ObtengaElSerialNumberExtranjero()
        {
            return $"SERIALNUMBER=NUP-{Identificacion}";
        }

        public string GivenName
        {
            get
            {
                return $"GivenName={NombreEnMayuscula}";
            }
        }

        public string SurName
        {
            get
            {
                return $"Surname={ApellidosFormateados}";
            }
        }
    }
}
