using System;

namespace ConObjetosConPolimorfismo
{
    internal class SerialNumberPorConsola
    {
        private string elPrefijoDelSerialNumber;
        private string laIdentificacion;

        public SerialNumberPorConsola(string laIdentificacion)
        {
            this.laIdentificacion = laIdentificacion;
            elPrefijoDelSerialNumber = ObtengaElPrefijo();
        }

        private string ObtengaElPrefijo()
        {
            Console.WriteLine("Indique el Serial Number:");
            return Console.ReadLine();
        }

        internal string Formateado()
        {
            return $"SERIALNUMBER={elPrefijoDelSerialNumber}-{laIdentificacion}";
        }
    }
}