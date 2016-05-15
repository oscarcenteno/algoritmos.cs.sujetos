namespace ConObjetosConParameterObject
{
    public class Solicitante
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public TipoDeIdentificacion TipoDeIdentificacion { get; set; }
    }
}