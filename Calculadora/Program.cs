namespace LaCalculadora
{
    using Calculadora;
    internal class Program
    {
        static void Main(string[] args)
        {
            float operando1;
            float operando2;

            string? recibido;
            bool verificarNumero;

            string? operacion;
            float? resultado;

            bool salir = false;
            string? respuestaSalir;

            do
            {

                Console.WriteLine("------------CALCULADORA------------");
                Console.WriteLine("Ingrese el primer numero: ");
                recibido = Console.ReadLine();

                verificarNumero = float.TryParse(recibido, out operando1);

                while (verificarNumero == false)
                {
                    Console.WriteLine("Error el dato ingresado no es un numero");
                    Console.WriteLine("Ingrese de nuevo el primer numero:");
                    recibido = Console.ReadLine();
                    verificarNumero = float.TryParse(recibido, out operando1);
                }

                Console.WriteLine("Ingrese el segundo numero: ");
                recibido = Console.ReadLine();

                verificarNumero = float.TryParse(recibido, out operando2);

                while (verificarNumero == false)
                {
                    Console.WriteLine("Error el dato ingresado no es un numero");
                    Console.WriteLine("Ingrese de nuevo el segundo numero:");
                    recibido = Console.ReadLine();
                    verificarNumero = float.TryParse(recibido, out operando2);
                }

                Console.WriteLine("Ingrese la operacion (+,-,/,*)");
                operacion = Console.ReadLine();

                while (operacion != "+" && operacion != "-" && operacion != "/" && operacion != "*")
                {
                    Console.WriteLine("Error, ingrese la operacion (+,-,/,*)");
                    operacion = Console.ReadLine();
                }

                resultado = Calculadora.Calcular(operando1, operando2, operacion);
                Console.WriteLine($"El resultado de la operacion es: {resultado}");

                Console.WriteLine("¿Desea salir?(si)");
                respuestaSalir = Console.ReadLine();

                if (respuestaSalir == "si")
                {
                    salir = true;
                }

            } while (salir == false);
        }
    }
}