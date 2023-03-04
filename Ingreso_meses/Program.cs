// See https://aka.ms/new-console-template for more information
using System;

namespace Ingresos_meses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PedirDatos();
        }
        static void PedirDatos()
        {
            Console.WriteLine("Hola, ingresa tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el salario de tus ultimos 3 meses");
            int sueldo1 = int.Parse(Console.ReadLine());
            int sueldo2 = int.Parse(Console.ReadLine());
            int sueldo3 = int.Parse(Console.ReadLine());

            int total = sueldo1 + sueldo2 + sueldo3;
            double promedio = total / 3.0;

            Console.WriteLine("Hola {0} en total ganaste {1}, y promediaste {2}", nombre, total, promedio);
        }
    }
}

