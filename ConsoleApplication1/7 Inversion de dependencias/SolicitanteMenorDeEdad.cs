namespace ConObjetosConPolimorfismo
{
    public class SolicitanteMenorDeEdad : Solicitante
    {
        public override string OU
        {
            get
            {
                return new OUPorConsola().Formateado();
            }
        }

        public override string SerialNumber
        {
            get
            {
                return new SerialNumberPorConsola(Identificacion).Formateado();
            }
        }
    }
}
