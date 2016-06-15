namespace ConFunciones
{
    public static class GeneracionDeSujetos
    {
        public static string GenereElSujeto(string laIdentificacion,
            TipoDeIdentificacion elTipoDeIdentificacion,
            string elNombre,
            string elPrimerApellido,
            string elSegundoApellido,
            TipoDeCertificado elTipoDeCertificado)
        {
            string elNombreEnMayuscula = ObtengaElNombreEnMayuscula(elNombre);
            string losApellidosFormateados;
            losApellidosFormateados = ObtengaLosApellidosFormateados(elPrimerApellido, elSegundoApellido);

            return ObtengaElSujetoFormateado(laIdentificacion, elTipoDeIdentificacion, elTipoDeCertificado, elNombreEnMayuscula, losApellidosFormateados);
        }

        private static string ObtengaElNombreEnMayuscula(string elNombre)
        {
            return elNombre.ToUpper();
        }

        private static string ObtengaLosApellidosFormateados(string elPrimerApellido, string elSegundoApellido)
        {
            string losApellidosEnMayusculas;
            losApellidosEnMayusculas = ObtengaLosApellidosEnMayusculas(elPrimerApellido, elSegundoApellido);

            return ObtengaLosApellidosFormateados(losApellidosEnMayusculas);
        }

        private static string ObtengaLosApellidosEnMayusculas(string elPrimerApellido, string elSegundoApellido)
        {
            string losApellidos = ObtengaLosApellidos(elPrimerApellido, elSegundoApellido);
            return ConviertaAMayusculas(losApellidos);
        }

        private static string ObtengaLosApellidos(string elPrimerApellido, string elSegundoApellido)
        {
            return $"{elPrimerApellido} {elSegundoApellido}";
        }

        private static string ConviertaAMayusculas(string losApellidos)
        {
            return losApellidos.ToUpper();
        }

        private static string ObtengaLosApellidosFormateados(string losApellidosEnMayusculas)
        {
            return losApellidosEnMayusculas.TrimEnd();
        }

        private static string ObtengaElSujetoFormateado(string laIdentificacion, TipoDeIdentificacion elTipoDeIdentificacion, TipoDeCertificado elTipoDeCertificado, string elNombreEnMayuscula, string losApellidosFormateados)
        {
            string elCN = ObtengaElCN(elTipoDeCertificado, elNombreEnMayuscula, losApellidosFormateados);
            string elOU = ObtengaElOU(elTipoDeIdentificacion);
            string elO = ObtengaElO();
            string elC = ObtengaElC();
            string elGivenName = ObtengaElGivenName(elNombreEnMayuscula);
            string elSurName = ObtengaElSurname(losApellidosFormateados);
            string elSerialNumber = ObtengaElSerialNumber(laIdentificacion, elTipoDeIdentificacion);

            return FormateeElSujeto(elCN, elOU, elO, elC, elGivenName, elSurName, elSerialNumber);
        }

        private static string ObtengaElCN(TipoDeCertificado elTipoDeCertificado, string elNombreEnMayuscula, string losApellidosFormateados)
        {
            string elProposito = DetermineElProposito(elTipoDeCertificado);

            return FormateeECN(elNombreEnMayuscula, losApellidosFormateados, elProposito);
        }

        private static string DetermineElProposito(TipoDeCertificado elTipoDeCertificado)
        {
            if (EsDeAutenticacion(elTipoDeCertificado))
                return ObtengaElPropositoDeAutenticacion();
            else
                return ObtengaElPropositoDeFirma();
        }

        private static string ObtengaElPropositoDeFirma()
        {
            return "FIRMA";
        }

        private static string ObtengaElPropositoDeAutenticacion()
        {
            return "AUTENTICACION";
        }

        private static bool EsDeAutenticacion(TipoDeCertificado elTipoDeCertificado)
        {
            return elTipoDeCertificado == TipoDeCertificado.Autenticacion;
        }

        private static string FormateeECN(string elNombreEnMayuscula, string losApellidosFormateados, string elProposito)
        {
            return $"CN={elNombreEnMayuscula} {losApellidosFormateados} ({elProposito})";
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

        private static string FormateeElSujeto(string elCN, string elOU, string elO, string elC, string elGivenName, string elSurName, string elSerialNumber)
        {
            return $"{elCN}, {elOU}, {elO}, {elC}, {elGivenName}, {elSurName}, {elSerialNumber}";
        }
    }
}