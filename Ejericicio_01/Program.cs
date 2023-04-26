namespace Ejercicio_I01
{
    internal class Program
    {

        /*
         * Ingresar 5 números por consola, guardándolos en una variable escalar.
         * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
         */
        static void Main(string[] args)
        {
            int numero;
            int contador = 0;
            int maximo = 0;
            int minimo = 0;
            bool verificar = true;
            int promedio;
            string cadena;
            int acumulador = 0;

            while (contador < 5)
            {
                Console.WriteLine("Ingrese un numero");
                cadena = Console.ReadLine();

                verificar = int.TryParse(cadena, out numero);

                while (verificar == false)
                {
                    Console.WriteLine("Error el dato ingresado no es un numero");
                    Console.WriteLine("Ingrese un numero");
                    cadena = Console.ReadLine();
                    verificar = int.TryParse(cadena, out numero);
                }

                if (contador == 0)
                {
                    maximo = numero;
                    minimo = numero;
                }

                if (numero >= maximo)
                {
                    maximo = numero;
                }
                if (numero <= minimo)
                {
                    minimo = numero;
                }

                acumulador = acumulador + numero;

                contador = contador + 1;
            }

            promedio = acumulador / contador;

            Console.WriteLine("El maximo es {0}", maximo);
            Console.WriteLine("El minimo es {0}", minimo);
            Console.WriteLine("El promedio es {0}", promedio);

        }


    }
}