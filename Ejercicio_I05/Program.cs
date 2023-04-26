namespace Ejercicio_I05
{
    internal class Program 
    { 
        /*Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números,
         cuyas sumas son iguales.
         El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
        cuyas sumas son ambas iguales a 15.
        El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas 
        iguales a 595.
        Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.*/
        
        static void Main(string[] args)
        {
            int maximo;
            string numeroObtenido;
            bool verificarNum;

            int numero = 1;
            int acumuladorAtras;
            int acumuladorAdelante;

            Console.WriteLine("Ingrese un numero mayor a 1 ");
            numeroObtenido = Console.ReadLine();
            verificarNum = int.TryParse(numeroObtenido, out maximo);

            while (verificarNum == false) 
            {
                Console.WriteLine("Error, Ingrese un numero mayor a 1 ");
                numeroObtenido = Console.ReadLine();
                verificarNum = int.TryParse(numeroObtenido, out maximo);
            }

            while (numero < maximo)
            {
                numero++;
                acumuladorAdelante = 0;
                acumuladorAtras = 0;

                for (int i = 1; i < numero; i++) 
                {
                    acumuladorAtras = acumuladorAtras + i;
                }

                for (int j = numero + 1; j <= acumuladorAtras ; j++)
                {

                    if (acumuladorAdelante == acumuladorAtras || acumuladorAdelante > acumuladorAtras) 
                    {
                        break;                        
                    }
                    acumuladorAdelante = acumuladorAdelante + j;

                }

                if (acumuladorAtras == acumuladorAdelante) 
                {
                    Console.WriteLine("Es centro numerico: {0}", numero);
                }
            }            
        }
    }
}