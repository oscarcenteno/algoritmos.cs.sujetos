namespace ComoUnProcedimiento
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
            string elNombreEnMayuscula = elNombre.ToUpper();

            string losApellidos = $"{elPrimerApellido} {elSegundoApellido}";
            string losApellidosEnMayusculas = losApellidos.ToUpper();
            string losApellidosFormateados;
            losApellidosFormateados = losApellidosEnMayusculas.TrimEnd();

            string elProposito;
            if (elTipoDeCertificado == TipoDeCertificado.Autenticacion)
                elProposito = "AUTENTICACION";
            else
                elProposito = "FIRMA";

            string elCN;
            elCN = $"CN={elNombreEnMayuscula} {losApellidosFormateados} ({elProposito})";

            string elOU;
            if (elTipoDeIdentificacion == TipoDeIdentificacion.Cedula)
                elOU = "OU=CIUDADANO";
            else
                elOU = "OU=EXTRANJERO";

            string elO = "O=PERSONA FISICA";
            string elC = "C=CR";
            string elGivenName = $"GivenName={elNombreEnMayuscula}";
            string elSurName = $"Surname={losApellidosFormateados}";

            string elSerialNumber;
            if (elTipoDeIdentificacion == TipoDeIdentificacion.Cedula)
                elSerialNumber = $"SERIALNUMBER=CPF-{laIdentificacion}";
            else
                elSerialNumber = $"SERIALNUMBER=NUP-{laIdentificacion}";

            return $"{elCN}, {elOU}, {elO}, {elC}, {elGivenName}, {elSurName}, {elSerialNumber}";
        }
    }
}