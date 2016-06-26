namespace ConParameterObject
{
    public class CN
    {
        private string elProposito;
        private string elNombreEnMayuscula;
        private string losApellidosFormateados;

        public CN(InformacionFormateada laInformacion)
        {
            elProposito = DetermineElProposito(laInformacion);
            elNombreEnMayuscula = laInformacion.NombreEnMayuscula;
            losApellidosFormateados = laInformacion.ApellidosFormateados;
        }

        private static string DetermineElProposito(InformacionFormateada laInformacion)
        {
            // TODO: Mas de una operacion
            if (EsDeAutenticacion(laInformacion.TipoDeCertificado))
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
            return $"CN={elNombreEnMayuscula} {losApellidosFormateados} ({elProposito})";
        }
    }
}