using ConObjetosConPolimorfismo;
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Sujetos de autenticación para menores de edad");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();

            SolicitanteMenorDeEdad elSolicitante = new SolicitanteMenorDeEdad();

            Console.WriteLine("Ingrese su identificación");
            elSolicitante.Identificacion = Console.ReadLine();
            Console.WriteLine("Ingrese su nombre");
            elSolicitante.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su primer apellido");
            elSolicitante.PrimerApellido = Console.ReadLine();
            Console.WriteLine("Ingrese su segundo apellido");
            elSolicitante.SegundoApellido = Console.ReadLine();

            // Aqui funciona las dependencias invertidas:
            // El componente Negocio va a pedir los datos del SolicitanteMenorDeEdada
            // a traves de la aplicacion de Consola sin saber que es una aplicacion
            // de consola.
            SujetoDeAutenticacion elSujeto = new SujetoDeAutenticacion(elSolicitante);

            Console.WriteLine();
            Console.WriteLine("Sujeto generado:");
            Console.WriteLine(elSujeto.Formateado());
            Console.WriteLine("---------------------------------------------");
            Console.ReadLine();
        }
    }
}