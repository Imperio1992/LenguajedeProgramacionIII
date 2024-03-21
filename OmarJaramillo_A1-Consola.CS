using System;

namespace ACTIVIDAD1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mensaje de bienvenida
            Console.WriteLine("Bienvenidos a UMI/Universidad Coppel");

            // Solicitud y captura de los datos del usuario
            string nombreCompleto = CapturarDato("Por favor ingrese su nombre completo: ");
            int edad = CapturarEntero("Ingrese su edad: ");
            DateTime fechaNacimiento = CapturarFecha("Ingrese su fecha de nacimiento (YYYY-MM-DD): ");
            string carrera = CapturarDato("Ingrese la carrera a la que desea ingresar: ");

            // Mensaje de agradecimiento y datos ingresados
            Console.WriteLine($"\nGracias {nombreCompleto} por formar parte de UMI/Universidad Coppel.");
            Console.WriteLine($"Bienvenido a la carrera de {carrera}.\n");

            // Muestra de datos ingresados
            Console.WriteLine("Datos del aspirante:");
            Console.WriteLine($"Nombre completo: {nombreCompleto}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Fecha de Nacimiento: {fechaNacimiento.ToString("yyy-MM-dd")}");
            Console.WriteLine($"Carrera deseada: {carrera}");

            Console.ReadKey();
        }

        // Metodo para capturar un dato del usuario
        static string CapturarDato(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine();
        }

        // Metodo para capturar un entero del usuario, con validacion de entrada
        static int CapturarEntero(string mensaje)
        {
            int valor;
            bool entradaValida = false;

            do
            {
                Console.Write(mensaje);
                entradaValida = int.TryParse(Console.ReadLine(), out valor);

                if (!entradaValida)
                {
                    Console.WriteLine("Por favor ingrese un valor numerico valido.");
                }

            } while (!entradaValida);

            return valor;
        }

        // Metodo para capturar una fecha del usuario, con validacion de entrada
        static DateTime CapturarFecha(string mensaje)
        {
            DateTime fecha;
            bool entradaValida = false;

            do
            {
                Console.Write(mensaje);
                entradaValida = DateTime.TryParse(Console.ReadLine(), out fecha);

                if (!entradaValida)
                {
                    Console.WriteLine("Por favor ingrese una fecha valida en el formato especificado (YYYY-MM-DD).");
                }

            } while (!entradaValida);

            return fecha;
        }
    }
}