namespace ConObjetos
{
    public class CN
    {
        private string elProposito;
        private string elNombreEnMayuscula;
        private string losApellidosFormateados;

        public CN(TipoDeCertificado elTipoDeCertificado, string elNombreEnMayuscula, string losApellidosFormateados)
        {
            elProposito = DetermineElProposito(elTipoDeCertificado);
            this.elNombreEnMayuscula = elNombreEnMayuscula;
            this.losApellidosFormateados = losApellidosFormateados;
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

        public string ComoTexto()
        {
            return FormateeECN(elNombreEnMayuscula, losApellidosFormateados, elProposito);
        }

        private static string FormateeECN(string elNombreEnMayuscula, string losApellidosFormateados, string elProposito)
        {
            return $"CN={elNombreEnMayuscula} {losApellidosFormateados} ({elProposito})";
        }
    }
}