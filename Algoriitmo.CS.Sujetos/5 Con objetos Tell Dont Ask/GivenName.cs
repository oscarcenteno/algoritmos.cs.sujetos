namespace ConObjetosTellDontAsk
{
    internal class GivenName
    {
        private string elNombreEnMayusculas;

        public GivenName(Solicitante elSolicitante)
        {
            elNombreEnMayusculas = elSolicitante.NombreEnMayusculas;
        }

        internal string ComoTexto()
        {
            return "GivenName=" + elNombreEnMayusculas;
        }
    }
}