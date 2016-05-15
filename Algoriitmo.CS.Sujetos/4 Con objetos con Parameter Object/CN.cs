namespace ConObjetosConParameterObject
{
    public class CN
    {
        private string elNombreEnMayuscula;
        private string losApellidosFormateados;
        string elProposito;

        public CN(Solicitante elSolicitante, TipoDeCertificado elTipoDeCertificado)
        {
            elNombreEnMayuscula = ObtengaElNombreEnMayusculas(elSolicitante);
            losApellidosFormateados = ObtengaLosApellidosFormateadosSinEspaciosAlFinal(elSolicitante);
            elProposito = DetermineElProposito(elTipoDeCertificado);
        }

        private string ObtengaLosApellidosFormateadosSinEspaciosAlFinal(Solicitante elSolicitante)
        {
            return new ApellidosFormateados(elSolicitante).SinEspaciosAlFinal();
        }

        private string ObtengaElNombreEnMayusculas(Solicitante elSolicitante)
        {
            // Demeter
            return elSolicitante.Nombre.ToUpper();
        }

        private static string DetermineElProposito(TipoDeCertificado elTipoDeCertificado)
        {
            if (elTipoDeCertificado == TipoDeCertificado.DeFirma)
                return "FIRMA";
            else
                return "AUTENTICACION";
        }

        public string Formateado()
        {
            return $"CN={elNombreEnMayuscula} {losApellidosFormateados} ({elProposito})";
        }
    }
}