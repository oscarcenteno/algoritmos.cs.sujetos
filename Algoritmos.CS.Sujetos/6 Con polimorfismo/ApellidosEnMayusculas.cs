namespace ConPolimorfismo
{
    public class ApellidosEnMayusculas
    {
        private string losApellidos;

        public ApellidosEnMayusculas(InformacionDelSolicitante laInformacion)
        {
            losApellidos = laInformacion.ApellidosEnMayusculas;
        }

        public string ComoTexto()
        {
            return losApellidos.ToUpper();
        }
    }
}