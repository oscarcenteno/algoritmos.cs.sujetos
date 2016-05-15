using System;

namespace ConFunciones
{
    public static class GeneracionDeSujetos
    {
        public static string GenereElSujeto(string laIdentificacion,
            string elNombre,
            string elPrimerApellido,
            string elSegundoApellido,
            TipoDeIdentificacion elTipoDeIdentificacion,
            TipoDeCertificado elTipoDeCertificado)
        {
            string elCN;
            elCN = ObtengaElCN(elNombre, elPrimerApellido, elSegundoApellido, elTipoDeCertificado);
            string elOU;
            elOU = ObtengaElOU(elTipoDeIdentificacion);
            string elO;
            elO = ObtengaElO();
            string elC;
            elC = ObtengaElC();
            string elSurname;
            elSurname = ObtengaElSurname(elPrimerApellido, elSegundoApellido);
            string elGivenName;
            elGivenName = ObtengaElGivenName(elNombre);
            string elSerialNumber;
            elSerialNumber = ObtengaElSerialNumber(laIdentificacion, elTipoDeIdentificacion);

            return ObtengaElSujeto(elCN, elOU, elO, elC, elSurname, elGivenName, elSerialNumber);
        }

        private static string ObtengaLosApellidosFormateadosSinEspaciosAlFinal(string elPrimerApellido, string elSegundoApellido)
        {
            string losApellidosFormateados = ObtengaLosApellidosFormateados(elPrimerApellido, elSegundoApellido);

            return ObtengaElTextoSinEspaciosAlFinal(losApellidosFormateados);
        }

        private static string ObtengaLosApellidosFormateados(string elPrimerApellido, string elSegundoApellido)
        {
            string losApellidos = ObtengaLosApellidos(elPrimerApellido, elSegundoApellido);

            return FormateeEnMayusculas(losApellidos);
        }

        private static string ObtengaLosApellidos(string elPrimerApellido, string elSegundoApellido)
        {
            return $"{elPrimerApellido} {elSegundoApellido}";
        }

        private static string ObtengaElTextoSinEspaciosAlFinal(string elTexto)
        {
            return elTexto.TrimEnd();
        }

        private static string FormateeEnMayusculas(string elTexto)
        {
            return elTexto.ToUpper();
        }

        private static string ObtengaElCN(string elNombre, string elPrimerApellido, string elSegundoApellido, TipoDeCertificado elTipo)
        {
            string elNombreEnMayuscula = FormateeEnMayusculas(elNombre);
            string losApellidosFormateados = ObtengaLosApellidosFormateadosSinEspaciosAlFinal(elPrimerApellido, elSegundoApellido);
            string elProposito = DetermineElProposito(elTipo);

            return FormateeElCN(elNombreEnMayuscula, losApellidosFormateados, elProposito);
        }

        private static string DetermineElProposito(TipoDeCertificado elTipo)
        {
            if (elTipo == TipoDeCertificado.DeFirma)
                return "FIRMA";
            else
                return "AUTENTICACION";
        }

        private static string FormateeElCN(string elNombre, string losApellidos, string elProposito)
        {
            return $"CN={elNombre} {losApellidos} ({elProposito})";
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

        private static string ObtengaElSurname(string elPrimerApellido, string elSegundoApellido)
        {
            string losApellidosFormateados = ObtengaLosApellidosFormateadosSinEspaciosAlFinal(elPrimerApellido, elSegundoApellido);

            return $"Surname={losApellidosFormateados}";
        }

        private static string ObtengaElGivenName(string elNombre)
        {
            string elNombreEnMayuscula = FormateeEnMayusculas(elNombre);

            return "GivenName=" + elNombreEnMayuscula;
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

        private static string ObtengaElSujeto(string elCN, string elOU, string elO, string elC, string elSurname, string elGivenName, string elSerialNumber)
        {
            return $"{elCN}, {elOU}, {elO}, {elC}, {elGivenName}, {elSurname}, {elSerialNumber}";
        }
    }
}