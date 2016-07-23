namespace ConPolimorfismo
{
    public static class GeneracionDeSujetos
    {
        public static string GenereElSujeto(InformacionDelSolicitante laInformacion)
        {
            return new Sujeto(laInformacion).ComoTexto();
        }
    }
}