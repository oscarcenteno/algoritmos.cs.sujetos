namespace ConObjetosConParameterObject
{
    internal class SurName
    {
        private string losApellidosFormateados;

        public SurName(Solicitante elSolicitante)
        {
            losApellidosFormateados = new ApellidosFormateados(elSolicitante).SinEspaciosAlFinal();
        }

        internal string ComoTexto()
        {
            return $"Surname={losApellidosFormateados}";
        }
    }
}