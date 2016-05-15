namespace ConObjetosTellDontAsk
{
    public class CN
    {
        private string elNombre;
        private string losApellidosFormateados;
        private string elProposito;

        public CN(Solicitante elSolicitante, TipoDeCertificado elTipo)
        {
            elNombre = ObtengaElNombreEnMayuscula(elSolicitante);
            losApellidosFormateados = ObtengaLosApellidosFormateados(elSolicitante);
            elProposito = DetermineElProposito(elTipo);
        }

        private string ObtengaLosApellidosFormateados(Solicitante elSolicitante)
        {
            return new ApellidosFormateados(elSolicitante).SinEspaciosAlFinal();
        }

        private string ObtengaElNombreEnMayuscula(Solicitante elSolicitante)
        {
            return elSolicitante.NombreEnMayusculas;
        }

        private static string DetermineElProposito(TipoDeCertificado elTipo)
        {
            if (elTipo == TipoDeCertificado.DeFirma)
                return "FIRMA";
            else
                return "AUTENTICACION";
        }

        public string Formateado()
        {
            return $"CN={elNombre} {losApellidosFormateados} ({elProposito})";
        }
    }
}