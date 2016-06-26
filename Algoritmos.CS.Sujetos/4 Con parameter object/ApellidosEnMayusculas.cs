namespace ConParameterObject
{
    public class ApellidosEnMayusculas
    {
        private string losApellidos;

        public ApellidosEnMayusculas(InformacionDelSolicitante laInformacion)
        {
            // TODO: Mas de una operacion
            losApellidos = $"{laInformacion.PrimerApellido} {laInformacion.SegundoApellido}";
        }

        public string ComoTexto()
        {
            return losApellidos.ToUpper();
        }
    }
}