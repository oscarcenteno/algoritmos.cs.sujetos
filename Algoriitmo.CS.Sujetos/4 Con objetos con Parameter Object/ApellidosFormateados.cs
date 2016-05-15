namespace ConObjetosConParameterObject
{
    internal class ApellidosFormateados
    {
        private string losApellidosFormateados;

        public ApellidosFormateados(Solicitante elSolicitante)
        {
            losApellidosFormateados = new Apellidos(elSolicitante).Formateados();
        }

        internal string SinEspaciosAlFinal()
        {
            return losApellidosFormateados.TrimEnd();
        }
    }
}