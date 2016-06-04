namespace ConObjetosConParameterObject
{
    internal class Apellidos
    {
        private string losApellidos;

        public Apellidos(Solicitante elSolicitante)
        {
            // Una sola operación
            losApellidos = $"{elSolicitante.PrimerApellido} {elSolicitante.SegundoApellido}";
        }

        internal string Formateados()
        {
            return losApellidos.ToUpper();
        }
    }
}