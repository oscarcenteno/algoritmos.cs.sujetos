namespace ConPolimorfismo
{
    public class InformacionDelSolicitante
    {
        public string Identificacion { get; set; }
        public TipoDeIdentificacion TipoDeIdentificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public TipoDeCertificado TipoDeCertificado { get; set; }

        public string NombreEnMayuscula
        {
            get
            {
                return Nombre.ToUpper();
            }
        }

        public string ApellidosEnMayusculas
        {
            get
            {
                return $"{PrimerApellido} {SegundoApellido}";
            }
        }
    }
}
