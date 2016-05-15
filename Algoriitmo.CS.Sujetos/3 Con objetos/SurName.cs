namespace ConObjetos
{
    internal class SurName
    {
        private string losApellidosFormateados;

        public SurName(string elPrimerApellido, string elSegundoApellido)
        {
            losApellidosFormateados = new ApellidosFormateados(elPrimerApellido, elSegundoApellido).SinEspaciosAlFinal();
        }

        internal string ComoTexto()
        {
            return $"Surname={losApellidosFormateados}";
        }
    }
}