namespace ConObjetosConParameterObject
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

        public Sujeto(Solicitante elSolicitante)
        {
            elCN = ObtengaElCN(elSolicitante);
            elOU = ObtengaElOU(elSolicitante);
            elO = FormateeElO();
            elC = FormateeElC();
            elSurname = FormateeElSurname(elSolicitante);
            elGivenName = ObtengaElGivenName(elSolicitante);
            elSerialNumber = ObtengaElSerialNumber(elSolicitante);
        }

        private static string ObtengaElCN(Solicitante elSolicitante)
        {
            return new CN(elSolicitante).Formateado();
        }

        public string Formateado()
        {
            return $"{elCN}, {elOU}, {elO}, {elC}, {elGivenName}, {elSurname}, {elSerialNumber}";
        }

        private static string ObtengaElOU(Solicitante elSolicitante)
        {
            // Una sola operación
            if (elSolicitante.TipoDeIdentificacion == TipoDeIdentificacion.Cedula)
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

        private static string FormateeElO()
        {
            return "O=PERSONA FISICA";
        }

        private static string FormateeElC()
        {
            return "C=CR";
        }

        private string FormateeElSurname(Solicitante elSolicitante)
        {
            return new SurName(elSolicitante).ComoTexto();
        }

        private string ObtengaLosApellidosFormateadosSinEspaciosAlFinal(Solicitante elSolicitante)
        {
            return new ApellidosFormateados(elSolicitante).SinEspaciosAlFinal();
        }

        private string ObtengaElGivenName(Solicitante elSolicitante)
        {
            return new GivenName(elSolicitante).ComoTexto();
        }

        private static string ObtengaElSerialNumber(Solicitante elSolicitante)
        {
            // Una sola operación
            if (elSolicitante.TipoDeIdentificacion == TipoDeIdentificacion.Cedula)
                return FormateeElSerialNumberParaUnNacional(elSolicitante);
            else
                return FormateeElNumeroDeSerieParaUnExtranjero(elSolicitante);
        }

        private static string FormateeElSerialNumberParaUnNacional(Solicitante elSolicitante)
        {
            // Una sola operación
            return $"SERIALNUMBER=CPF-{elSolicitante.Identificacion}";
        }

        private static string FormateeElNumeroDeSerieParaUnExtranjero(Solicitante elSolicitante)
        {
            // Una sola operación
            return $"SERIALNUMBER=NUP-{elSolicitante.Identificacion}";
        }
    }
}