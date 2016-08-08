using ConPolimorfismo;
using System;

namespace ConsoleApplication1
{
    internal class InformacionParaUnMenorDeEdadMedico : InformacionFormateada
    {
        public override string OU
        {
            get
            {
                return "OU=MENOR DE EDAD";
            }
        }

        public override string Proposito
        {
            get
            {
                Console.WriteLine("Indique el proposito, por favor:");
                return Console.ReadLine();
            }
        }

        public override string SerialNumber
        {
            get
            {
                return $"SERIALNUMBER=MENOR-{Identificacion}";
            }
        }
    }
}