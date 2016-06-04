namespace ConObjetosConParameterObject
{
    public class CN
    {
        private string elNombreEnMayuscula;
        private string losApellidosFormateados;
        private string elProposito;

        public CN(Solicitante elSolicitante)
        {
            elNombreEnMayuscula = ObtengaElNombreEnMayusculas(elSolicitante);
            losApellidosFormateados = ObtengaLosApellidosFormateadosSinEspaciosAlFinal(elSolicitante);
            elProposito = DetermineElProposito(elSolicitante);
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

        private static string DetermineElProposito(Solicitante elSolicitante)
        {
            // Una sola operación
            if (elSolicitante.TipoDeCertificado == TipoDeCertificado.DeFirma)
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