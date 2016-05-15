namespace ConObjetos
{
    public class Sujeto
    {
        string elCN;
        string elOU;
        string elO;
        string elC;
        string elSurname;
        string elGivenName;
        string elSerialNumber;

        public Sujeto(string laIdentificacion,
            string elNombre,
            string elPrimerApellido,
            string elSegundoApellido,
            TipoDeIdentificacion elTipoDeIdentificacion,
            TipoDeCertificado elTipoDeCertificado)
        {
            elCN = ObtengaElCN(elNombre, elPrimerApellido, elSegundoApellido, elTipoDeCertificado);
            elOU = ObtengaElOU(elTipoDeIdentificacion);
            elO = ObtengaElO();
            elC = ObtengaElC();
            elSurname = ObtengaElSurname(elPrimerApellido, elSegundoApellido);
            elGivenName = ObtengaElGivenName(elNombre);
            elSerialNumber = ObtengaElSerialNumber(laIdentificacion, elTipoDeIdentificacion);
        }

        private string ObtengaLosApellidosFormateadosSinEspaciosAlFinal(string elPrimerApellido, string elSegundoApellido)
        {
            return new ApellidosFormateados(elPrimerApellido, elSegundoApellido).SinEspaciosAlFinal();
        }

        private static string ObtengaElCN(string elNombre, string elPrimerApellido, string elSegundoApellido, TipoDeCertificado elTipoDeCertificado)
        {
            return new CN(elNombre, elPrimerApellido, elSegundoApellido, elTipoDeCertificado).Formateado();
        }

        public string Formateado()
        {
            return $"{elCN}, {elOU}, {elO}, {elC}, {elGivenName}, {elSurname}, {elSerialNumber}";
        }

        private static string FormateeEnMayusculas(string elTexto)
        {
            return elTexto.ToUpper();
        }

        private static string ObtengaElOU(TipoDeIdentificacion elTipoDeIdentificacion)
        {
            if (elTipoDeIdentificacion == TipoDeIdentificacion.Cedula)
                return FormateeElOUParaUnNacional();
            else
                return FormateeElOUParaUnExtranjero();
        }

        private static string FormateeElOUParaUnNacional()
        {
            return "OU=CIUDADANO";
        }

        private static string FormateeElOUParaUnExtranjero()
        {
            return "OU=EXTRANJERO";
        }

        private static string ObtengaElO()
        {
            return "O=PERSONA FISICA";
        }

        private static string ObtengaElC()
        {
            return "C=CR";
        }

        private string ObtengaElSurname(string elPrimerApellido, string elSegundoApellido)
        {
            return new SurName(elPrimerApellido, elSegundoApellido).ComoTexto();
        }

        private string ObtengaElGivenName(string elNombre)
        {
            return new GivenName(elNombre).ComoTexto();
        }

        private static string ObtengaElSerialNumber(string laIdentificacion, TipoDeIdentificacion elTipoDeIdentificacion)
        {
            if (elTipoDeIdentificacion == TipoDeIdentificacion.Cedula)
                return FormateeElSerialNumberParaUnNacional(laIdentificacion);
            else
                return FormateeElNumeroDeSerieParaUnExtranjero(laIdentificacion);
        }

        private static string FormateeElSerialNumberParaUnNacional(string laIdentificacion)
        {
            return $"SERIALNUMBER=CPF-{laIdentificacion}";
        }

        private static string FormateeElNumeroDeSerieParaUnExtranjero(string laIdentificacion)
        {
            return $"SERIALNUMBER=NUP-{laIdentificacion}";
        }
    }
}