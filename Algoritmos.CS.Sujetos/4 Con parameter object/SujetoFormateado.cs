namespace ConParameterObject
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

        public SujetoFormateado(InformacionFormateada laInformacion)
        {
            elCN = ObtengaElCN(laInformacion);
            elOU = ObtengaElOU(laInformacion);
            elO = ObtengaElO();
            elC = ObtengaElC();
            elGivenName = ObtengaElGivenName(laInformacion);
            elSurName = ObtengaElSurname(laInformacion);
            elSerialNumber = ObtengaElSerialNumber(laInformacion);
        }

        private static string ObtengaElCN(InformacionFormateada laInformacion)
        {
            return new CN(laInformacion).ComoTexto();
        }

        private static string ObtengaElOU(InformacionFormateada laInformacion)
        {
            if (EsNacional(laInformacion.TipoDeIdentificacion))
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

        private static string ObtengaElGivenName(InformacionFormateada laInformacion)
        {
            // TODO: Mas de una sola operacion
            return $"GivenName={laInformacion.NombreEnMayuscula}";
        }

        private static string ObtengaElSurname(InformacionFormateada laInformacion)
        {
            // TODO: Mas de una sola operacion
            return $"Surname={laInformacion.ApellidosFormateados}";
        }

        private static string ObtengaElSerialNumber(InformacionFormateada laInformacion)
        {
            // TODO: Mas de una sola operacion
            if (EsNacional(laInformacion.TipoDeIdentificacion))
                return ObtengaElSerialNumberNacional(laInformacion);
            else
                return ObtengaElSerialNumberExtranjero(laInformacion);
        }

        private static string ObtengaElSerialNumberExtranjero(InformacionFormateada laInformacion)
        {
            // TODO: Mas de una sola operacion
            return $"SERIALNUMBER=NUP-{laInformacion.Identificacion}";
        }

        private static string ObtengaElSerialNumberNacional(InformacionFormateada laInformacion)
        {
            // TODO: Mas de una sola operacion
            return $"SERIALNUMBER=CPF-{laInformacion.Identificacion}";
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