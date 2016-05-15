namespace ConObjetosTellDontAsk
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

        public Sujeto(Solicitante elSolicitante, TipoDeCertificado elTipoDeCertificado)
        {
            elCN = ObtengaElCN(elSolicitante, elTipoDeCertificado);
            elOU = ObtengaElOU(elSolicitante);
            elO = ObtengaElO();
            elC = ObtengaElC();
            elSurname = ObtengaElSurname(elSolicitante);
            elGivenName = ObtengaElGivenName(elSolicitante);
            elSerialNumber = ObtengaElSerialNumber(elSolicitante);
        }

        private string ObtengaElCN(Solicitante elSolicitante, TipoDeCertificado elTipoDeCertificado)
        {
            return new CN(elSolicitante, elTipoDeCertificado).Formateado();
        }

        private static string ObtengaElOU(Solicitante elSolicitante)
        {
            if (elSolicitante.EsNacional())
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

        private string ObtengaElO()
        {
            return "O=PERSONA FISICA";
        }

        private string ObtengaElC()
        {
            return "C=CR";
        }

        private string ObtengaElSurname(Solicitante elSolicitante)
        {
            return new SurName(elSolicitante).ComoTexto();
        }

        private string ObtengaElGivenName(Solicitante elSolicitante)
        {
            return new GivenName(elSolicitante).ComoTexto();
        }

        private static string ObtengaElSerialNumber(Solicitante elSolicitante)
        {
            if (elSolicitante.EsNacional())
                return FormateeElSerialNumberParaUnNacional(elSolicitante);
            else
                return FormateeElNumeroDeSerieParaUnExtranjero(elSolicitante);
        }

        private static string FormateeElSerialNumberParaUnNacional(Solicitante elSolicitante)
        {
            return elSolicitante.SerialNumberNacional;
        }

        private static string FormateeElNumeroDeSerieParaUnExtranjero(Solicitante elSolicitante)
        {
            return elSolicitante.SerialNumberExtranjero;
        }

        public string Formateado()
        {
            return $"{elCN}, {elOU}, {elO}, {elC}, {elGivenName}, {elSurname}, {elSerialNumber}";
        }
    }
}