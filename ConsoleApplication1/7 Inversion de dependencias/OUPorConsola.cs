using System;

namespace ConObjetosConPolimorfismo
{
    internal class OUPorConsola
    {
        private string elOU;

        public OUPorConsola()
        {
            Console.WriteLine("Indique el OU:");
            elOU = Console.ReadLine();
        }

        internal string Formateado()
        {
            return $"OU={elOU}";
        }
    }
}