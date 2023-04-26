namespace CM_Ejercicio_05
{
    using Tablas;
    internal class Program
    {
        /*Crear una aplicación de consola que permita al usuario ingresar un número entero. 
        Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.
        Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.
        Mostrar en la consola el resultado.
        Por ejemplo, si se ingresa el número 2 la salida deberá ser:*/

        static void Main(string[] args)
        {
            int numero;
            string numeroRecibido;
            bool verificar;

            Console.WriteLine("Ingrese un numero: ");
            numeroRecibido = Console.ReadLine();
            verificar = int.TryParse(numeroRecibido, out numero);

            while (!verificar) 
            {
                Console.WriteLine("Error, ingrese un numero: ");
                numeroRecibido = Console.ReadLine();
                verificar = int.TryParse(numeroRecibido, out numero);
            }
            
            Console.WriteLine(Tablas.MostrarTabla(numero));

        }
    }
}