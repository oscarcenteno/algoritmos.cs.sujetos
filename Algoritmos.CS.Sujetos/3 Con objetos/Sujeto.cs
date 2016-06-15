namespace ConObjetos
{
    public class Sujeto
    {
        private string elNombreEnMayuscula;
        private string losApellidosFormateados;
        private TipoDeCertificado elTipoDeCertificado;
        private TipoDeIdentificacion elTipoDeIdentificacion;
        private string laIdentificacion;

        public Sujeto(string laIdentificacion,
            TipoDeIdentificacion elTipoDeIdentificacion,
            string elNombre,
            string elPrimerApellido,
            string elSegundoApellido,
            TipoDeCertificado elTipoDeCertificado)
        {
            elNombreEnMayuscula = ObtengaElNombreEnMayuscula(elNombre);
            losApellidosFormateados = ObtengaLosApellidosFormateados(elPrimerApellido, elSegundoApellido);
            this.elTipoDeCertificado = elTipoDeCertificado;
            this.elTipoDeIdentificacion = elTipoDeIdentificacion;
            this.laIdentificacion = laIdentificacion;
        }

        private static string ObtengaElNombreEnMayuscula(string elNombre)
        {
            return elNombre.ToUpper();
        }

        private static string ObtengaLosApellidosFormateados(string elPrimerApellido, string elSegundoApellido)
        {
            return new ApellidosFormateados(elPrimerApellido, elSegundoApellido).ComoTexto();
        }

        public string ComoTexto()
        {
            return new SujetoFormateado(laIdentificacion, elTipoDeIdentificacion, elTipoDeCertificado, elNombreEnMayuscula, losApellidosFormateados).ComoTexto();
        }
    }
}