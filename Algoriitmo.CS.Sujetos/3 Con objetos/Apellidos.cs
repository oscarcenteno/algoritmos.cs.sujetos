namespace ConObjetos
{
    internal class Apellidos
    {
        private string losApellidos;

        public Apellidos(string elPrimerApellido, string elSegundoApellido)
        {
            losApellidos = $"{elPrimerApellido} {elSegundoApellido}";
        }

        internal string Formateados()
        {
            return losApellidos.ToUpper();
        }
    }
}