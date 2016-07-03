﻿namespace ConTellDontAsk
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
            return laInformacion.ObtengaElOU();
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
            return laInformacion.ObtengaElGivenName();
        }

        private static string ObtengaElSurname(InformacionFormateada laInformacion)
        {
            return laInformacion.ObtengaElSurName();
        }

        private static string ObtengaElSerialNumber(InformacionFormateada laInformacion)
        {
            return laInformacion.ObtengaElSerialNumber();
        }
        
        public string ComoTexto()
        {
            return $"{elCN}, {elOU}, {elO}, {elC}, {elGivenName}, {elSurName}, {elSerialNumber}";
        }
    }
}