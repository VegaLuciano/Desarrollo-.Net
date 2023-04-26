using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM__Ejercicio_I01
{
    using Validador;

    internal class Program
    {
        static void Main(string[] args)
        {
            string recibido;
            bool verificarNumero;
            int numero;
            int contador = 0;
            bool validadorRango;

            int maximo = 0;
            int minimo = 0;
            int acumulador = 0;
            int promedio = 0;


            while(contador < 10)
            {

                Console.WriteLine("------------CALCULADORA------------");
                Console.WriteLine("Ingrese un numero: ");
                recibido = Console.ReadLine();

                verificarNumero = int.TryParse(recibido, out numero);
                validadorRango = Validador.Validar(numero, -100, 100);

                while (!verificarNumero || !validadorRango)
                {
                    Console.WriteLine("Error, ingrese un numero");
                    recibido = Console.ReadLine();
                    verificarNumero = int.TryParse(recibido, out numero);
                    validadorRango = Validador.Validar(numero, -100, 100);
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

                contador++;
            }

            promedio = acumulador / contador;

            Console.WriteLine("El maximo es {0}", maximo);
            Console.WriteLine("El minimo es {0}", minimo);
            Console.WriteLine("El promedio es {0}", promedio);

        }
    }
}