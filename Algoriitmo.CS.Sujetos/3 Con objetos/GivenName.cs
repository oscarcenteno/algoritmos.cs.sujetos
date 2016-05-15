namespace ConObjetos
{
    internal class GivenName
    {
        private string elNombreEnMayusculas;

        public GivenName(string elNombre)
        {
            elNombreEnMayusculas = elNombre.ToUpper();
        }

        internal string ComoTexto()
        {
            return "GivenName=" + elNombreEnMayusculas;
        }
    }
}