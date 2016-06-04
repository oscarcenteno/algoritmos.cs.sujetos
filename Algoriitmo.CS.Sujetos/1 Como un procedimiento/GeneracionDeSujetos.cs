namespace ComoUnProcedimiento
{
    public static class GeneracionDeSujetos
    {
        public static string GenereElSujeto(string laIdentificacion,
            string elNombre,
            string elPrimerApellido,
            string elSegundoApellido,
            TipoDeIdentificacion elTipoDeIdentificacion,
            TipoDeCertificado elTipo)
        {
            string elNombreEnMayuscula;
            elNombreEnMayuscula = elNombre.ToUpper();

            string losApellidos;
            losApellidos = $"{elPrimerApellido} {elSegundoApellido}";

            string losApellidosFormateados;
            losApellidosFormateados = losApellidos.ToUpper();

            string losApellidosFormateadosSinEspaciosAlFinal;
            losApellidosFormateadosSinEspaciosAlFinal = losApellidosFormateados.TrimEnd();

            string elProposito;
            if (elTipo == TipoDeCertificado.DeFirma)
                elProposito = "FIRMA";
            else
                elProposito = "AUTENTICACION";

            string elCN;
            elCN = $"CN={elNombreEnMayuscula} {losApellidosFormateadosSinEspaciosAlFinal} ({elProposito})";

            string elOU;
            if (elTipoDeIdentificacion == TipoDeIdentificacion.Cedula)
                elOU = "OU=CIUDADANO";
            else
                elOU = "OU=EXTRANJERO";

            string elO;
            elO = "O=PERSONA FISICA";

            string elC;
            elC = "C=CR";

            string elGivenName;
            elGivenName = $"GivenName={elNombreEnMayuscula}";

            string elSurname;
            elSurname = $"Surname={losApellidosFormateadosSinEspaciosAlFinal}";

            string elSerialNumber;
            if (elTipoDeIdentificacion == TipoDeIdentificacion.Cedula)
                elSerialNumber = $"SERIALNUMBER=CPF-{laIdentificacion}";
            else
                elSerialNumber = $"SERIALNUMBER=NUP-{laIdentificacion}";

            return $"{elCN}, {elOU}, {elO}, {elC}, {elGivenName}, {elSurname}, {elSerialNumber}";
        }
    }
}