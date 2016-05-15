namespace ConObjetosTellDontAsk
{
    public class Solicitante
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public TipoDeIdentificacion TipoDeIdentificacion { get; set; }

        public string NombreEnMayusculas
        {
            get
            {
                return Nombre.ToUpper();
            }
        }

        public string Apellidos
        {
            get
            {
                return $"{PrimerApellido} {SegundoApellido}";
            }
        }

        public string SerialNumberNacional
        {
            get
            {
                return $"SERIALNUMBER=CPF-{Identificacion}";
            }
        }

        public string SerialNumberExtranjero
        {
            get
            {
                return $"SERIALNUMBER=NUP-{Identificacion}";
            }
        }

        internal bool EsNacional()
        {
            return TipoDeIdentificacion == TipoDeIdentificacion.Cedula;
        }
    }
}