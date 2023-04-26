using System.Reflection;

namespace Ejercicio_I03
{
    internal class Program
    {
        /*
        Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
        Validar que el dato ingresado por el usuario sea un número.
        Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
        Si ingresa "salir", cerrar la consola.
        Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar.
        De lo contrario, cerrar la consola.*/

        static void Main(string[] args)
        {
            bool cerrarConsola = false;
            string respuesta;

            string numObtenido;
            bool verificarNum;
            int numero;

            do
            {
                Console.WriteLine("Ingresar un numero");
                numObtenido = Console.ReadLine();
                verificarNum = int.TryParse(numObtenido, out numero);

                while (verificarNum == false && cerrarConsola == false)
                {
                    Console.WriteLine("Error, Ingresar un numero o escriba salir para dejar de intentar ");
                    numObtenido = Console.ReadLine();

                    if (numObtenido == "salir")
                    {
                        cerrarConsola = true;
                    }
                    else
                    {
                        verificarNum = int.TryParse(numObtenido, out numero);
                    }
                }

                for (int i = 2; i <= numero; i++)
                {
                    bool comprobacion = true;

                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            comprobacion = false;
                            break;
                        }
                    }

                    if (comprobacion == true)
                    {
                        Console.WriteLine($" Es un numero primo {i}");
                    }

                }

                if (cerrarConsola == false)
                {
                    Console.WriteLine("Si desea volver a operar escriba: si");
                    respuesta = Console.ReadLine();
                    if (respuesta == "si")
                    {
                        cerrarConsola = false;
                    }
                    else
                    {
                        cerrarConsola = true;
                    }
                }

            } while (cerrarConsola == false);
        }
    }
}