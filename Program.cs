// See https://aka.ms/new-console-template for more information
ConvertirAEntero();
Console.ReadKey();

static void ConvertirAEntero()
{
    Console.WriteLine("Ingrese 2 numeros");
    try
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int total = n1 + n2;
        Console.WriteLine("El resultado es: {0}", total);
    }
    catch (Exception c)
    {
        Console.WriteLine("Ocurrio un error");
    }
    finally
    {
        Console.WriteLine("Programa terminado");
    }
}

