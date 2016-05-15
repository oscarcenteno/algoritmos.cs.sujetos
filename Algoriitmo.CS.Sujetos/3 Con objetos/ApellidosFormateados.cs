namespace ConObjetos
{
    internal class ApellidosFormateados
    {
        private string losApellidosFormateados;

        public ApellidosFormateados(string elPrimerApellido, string elSegundoApellido)
        {
            losApellidosFormateados = new Apellidos(elPrimerApellido, elSegundoApellido).Formateados();
        }

        internal string SinEspaciosAlFinal()
        {
            return losApellidosFormateados.TrimEnd();
        }        
    }
}