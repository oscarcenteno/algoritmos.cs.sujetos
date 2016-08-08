using ConPolimorfismo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            InformacionFormateada laInformacion = new InformacionParaUnMenorDeEdadMedico();
            laInformacion.Nombre = "Juan";
            laInformacion.PrimerApellido = "Sanchez";
            laInformacion.SegundoApellido = "Sosa";
            laInformacion.Identificacion = "4-4323-2345";

            string elSujeto = new SujetoFormateado(laInformacion).ComoTexto();

            Console.WriteLine("El sujeto es: ");
            Console.Write(elSujeto);
            Console.ReadLine();
        }
    }
}
