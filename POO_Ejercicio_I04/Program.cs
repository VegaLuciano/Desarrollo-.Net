namespace POO_Ejercicio_I04
{
    internal class Program
    {
        /*Agregar un proyecto de consola.
        En el método Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) y una cantidad inicial 
        de tinta de 100 y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.
        Utilizar todos los métodos y mostrar los resultados por consola.
        Al utilizar el método Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho bolígrafo.*/

        static void Main(string[] args)
        {
            Boligrafo boligrafo1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);

            string dibujo1 = "";
            string dibujo2 = "";

            bool comprobar;

            comprobar = boligrafo1.Pintar(100, out dibujo1);

            if (comprobar) 
            {
                Console.WriteLine($"El dibujo de color{boligrafo1.GetColor()} del primer boligrado es:");
                Console.WriteLine(dibujo1);
                Console.WriteLine($"Le queda {boligrafo1.GetTinta()} al primer boligrafo.");
            }       
            else
            {
                Console.WriteLine("No hay suficiente tinta");
            }

            comprobar = boligrafo2.Pintar(10, out dibujo2);

            if (comprobar)
            {
                Console.WriteLine($"El dibujo de color {boligrafo2.GetColor()}del segundo boligrado es:");
                Console.WriteLine(dibujo2);
                Console.WriteLine($"Le queda {boligrafo2.GetTinta()} al segundo boligrafo.");
            }
            else 
            {
                Console.WriteLine("No hay suficiente tinta");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Restauramos el color");

            Console.WriteLine("Recargamos el uno");
            boligrafo1.Recargar();
            Console.WriteLine("Recargamos el dos");
            boligrafo2.Recargar();

            Console.WriteLine($"Ahora el boligrafo uno esta al {boligrafo1.GetTinta()}");
            Console.WriteLine($"Ahora el boligrafo dos esta al {boligrafo2.GetTinta()}");

        }
    }
}