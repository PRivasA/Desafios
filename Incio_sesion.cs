// See https://aka.ms/new-console-template for more information
namespace Incio_sesion
{
    internal class program
    {
        static string nombre="";
        static string contrasena="";

        static void Main(string[] args)
        {
            Registrar();
            IniciarSesion();

            Console.ReadKey();
   
        }


        static void Registrar() {
            Console.WriteLine("Registro Ingrese nombre del usuario:");
            nombre = Console.ReadLine();
            Console.WriteLine("Registro Ingrese contrasena del usuario:");
            contrasena = Console.ReadLine();
        }
        static void IniciarSesion()
        {
            Console.WriteLine("Login Ingrese nombre del usuario:");
            string usuarioIngresado = Console.ReadLine();
            Console.WriteLine("login Ingrese contrasena del usuario:");
            string contrasenaIngresada = Console.ReadLine();

            if (nombre.ToLower().Equals(usuarioIngresado.ToLower()))
            {
                if (contrasena.Equals(contrasenaIngresada))
                {
                    Console.WriteLine("Bienvenido {0}", usuarioIngresado);
                }
                else
                {
                    Console.WriteLine("contrasena invalida");
                }
            }
            else
            {
                Console.WriteLine("El usuario es invalido");
            }
        }
    }
}
