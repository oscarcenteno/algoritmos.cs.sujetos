namespace ConObjetosConParameterObject
{
    internal class GivenName
    {
        private string elNombreEnMayusculas;

        public GivenName(Solicitante elSolicitante)
        {
            // Demeter
            elNombreEnMayusculas = elSolicitante.Nombre.ToUpper();
        }

        internal string ComoTexto()
        {
            return "GivenName=" + elNombreEnMayusculas;
        }
    }
}