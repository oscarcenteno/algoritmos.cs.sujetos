namespace ConObjetos
{
    public class SujetoFormateado
    {
        private string elCN;
        private string elOU;
        private string elO;
        private string elC;
        private string elGivenName;
        private string elSurName;
        private string elSerialNumber;

        public SujetoFormateado(string laIdentificacion, TipoDeIdentificacion elTipoDeIdentificacion, TipoDeCertificado elTipoDeCertificado, string elNombreEnMayuscula, string losApellidosFormateados)
        {
            elCN = ObtengaElCN(elTipoDeCertificado, elNombreEnMayuscula, losApellidosFormateados);
            elOU = ObtengaElOU(elTipoDeIdentificacion);
            elO = ObtengaElO();
            elC = ObtengaElC();
            elGivenName = ObtengaElGivenName(elNombreEnMayuscula);
            elSurName = ObtengaElSurname(losApellidosFormateados);
            elSerialNumber = ObtengaElSerialNumber(laIdentificacion, elTipoDeIdentificacion);
        }

        private static string ObtengaElCN(TipoDeCertificado elTipoDeCertificado, string elNombreEnMayuscula, string losApellidosFormateados)
        {
            return new CN(elTipoDeCertificado, elNombreEnMayuscula, losApellidosFormateados).ComoTexto();
        }

        private static string ObtengaElOU(TipoDeIdentificacion elTipoDeIdentificacion)
        {
            if (EsNacional(elTipoDeIdentificacion))
                return ObtengaElOUNacional();
            else
                return ObtengaElOUExtranjero();
        }

        private static string ObtengaElOUExtranjero()
        {
            return "OU=EXTRANJERO";
        }

        private static string ObtengaElOUNacional()
        {
            return "OU=CIUDADANO";
        }

        private static string ObtengaElO()
        {
            return "O=PERSONA FISICA";
        }

        private static string ObtengaElC()
        {
            return "C=CR";
        }

        private static string ObtengaElGivenName(string elNombreEnMayuscula)
        {
            return $"GivenName={elNombreEnMayuscula}";
        }

        private static string ObtengaElSurname(string losApellidosFormateados)
        {
            return $"Surname={losApellidosFormateados}";
        }

        private static string ObtengaElSerialNumber(string laIdentificacion, TipoDeIdentificacion elTipoDeIdentificacion)
        {
            if (EsNacional(elTipoDeIdentificacion))
                return ObtengaElSerialNumberNacional(laIdentificacion);
            else
                return ObtengaElSerialNumberExtranjero(laIdentificacion);
        }

        private static string ObtengaElSerialNumberExtranjero(string laIdentificacion)
        {
            return $"SERIALNUMBER=NUP-{laIdentificacion}";
        }

        private static string ObtengaElSerialNumberNacional(string laIdentificacion)
        {
            return $"SERIALNUMBER=CPF-{laIdentificacion}";
        }

        private static bool EsNacional(TipoDeIdentificacion elTipoDeIdentificacion)
        {
            return elTipoDeIdentificacion == TipoDeIdentificacion.Cedula;
        }

        public string ComoTexto()
        {
            return $"{elCN}, {elOU}, {elO}, {elC}, {elGivenName}, {elSurName}, {elSerialNumber}";
        }
    }
}