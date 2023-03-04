// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    static int Puntaje = 0;
    static int PuntuacionRecord = 0;
    static string JugadorRecord = "";

    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el nombre del jugador 1: ");
        string NombredelJugador1 = Console.ReadLine();

        Console.WriteLine("Ingrese el puntaje de jugador 1: ");
        int PuntuaciondelJugador1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el nombre de jugador 2: ");
        string NombredelJugador2 = Console.ReadLine();

        Console.WriteLine("Ingrese el puntaje de jugador 2: ");
        int PuntuaciondelJugador2 = Int32.Parse(Console.ReadLine());

        CheckScore(PuntuaciondelJugador1, NombredelJugador1);
        CheckScore(PuntuaciondelJugador2, NombredelJugador2);
    }

    static void CheckScore(int Puntaje, string Nombre)
    {
        if (Puntaje > PuntuacionRecord)
        {
            PuntuacionRecord = Puntaje;
            JugadorRecord = Nombre;

            Console.WriteLine("La nueva puntuación más alta es " + PuntuacionRecord);
            Console.WriteLine("La puntuación más alta fue lograda por " + JugadorRecord);
        }
        else
        {
            Console.WriteLine("La puntuación más alta de " + PuntuacionRecord + " no se ha podido superar, y aún está en manos de " + JugadorRecord);
        }
    }
}
