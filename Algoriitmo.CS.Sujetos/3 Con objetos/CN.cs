namespace ConObjetos
{
    class CN
    {
        private string elNombreEnMayuscula;
        private string losApellidosFormateados;
        string elProposito;

        public CN(string elNombre, string elPrimerApellido, string elSegundoApellido, TipoDeCertificado elTipoDeCertificado)
        {
            elNombreEnMayuscula = FormateeEnMayusculas(elNombre);
            losApellidosFormateados = ObtengaLosApellidosFormateadosSinEspaciosAlFinal(elPrimerApellido, elSegundoApellido);
            elProposito = DetermineElProposito(elTipoDeCertificado);
        }

        private string ObtengaLosApellidosFormateadosSinEspaciosAlFinal(string elPrimerApellido, string elSegundoApellido)
        {
            return new ApellidosFormateados(elPrimerApellido, elSegundoApellido).SinEspaciosAlFinal();
        }

        private string FormateeEnMayusculas(string elTexto)
        {
            return elTexto.ToUpper();
        }

        private static string DetermineElProposito(TipoDeCertificado elTipoDeCertificado)
        {
            if (elTipoDeCertificado == TipoDeCertificado.DeFirma)
                return "FIRMA";
            else
                return "AUTENTICACION";
        }

        public  string Formateado()
        {
            return $"CN={elNombreEnMayuscula} {losApellidosFormateados} ({elProposito})";
        }
    }
}