namespace Ejercicio_I02
{
    internal class Program
    {
        /*
         * 
         Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
        Se debe validar que el número sea mayor que cero, caso contrario, 
        mostrar el mensaje: "ERROR. ¡Reingresar número!".
         */

        static void Main(string[] args)
        {

            int numero;
            bool verificar;
            string cadena;

            do
            {
                Console.WriteLine("Ingrese un numero mayor a 0");
                cadena = Console.ReadLine();

                verificar = int.TryParse(cadena, out numero);

                while (verificar == false)
                {
                    Console.WriteLine("Error el dato ingresado no es un numero");
                    Console.WriteLine("Ingrese un numero");
                    cadena = Console.ReadLine();
                    verificar = int.TryParse(cadena, out numero);
                }

            } while (numero <= 0);

            Console.WriteLine("El cuardrado del numero es {0}", Math.Pow(numero, 2));
            Console.WriteLine("El cubo del numero es {0}", Math.Pow(numero, 3));

        }
    }
}