namespace ConObjetos
{
    public static class GeneracionDeSujetos
    {
        public static string GenereElSujeto(string laIdentificacion,
            TipoDeIdentificacion elTipoDeIdentificacion,
            string elNombre,
            string elPrimerApellido,
            string elSegundoApellido,
            TipoDeCertificado elTipoDeCertificado)
        {
            return new Sujeto(laIdentificacion, elTipoDeIdentificacion, elNombre, elPrimerApellido, elSegundoApellido, elTipoDeCertificado).ComoTexto();
        }
    }
}