namespace POO_Ejercicio_01
{
    using Cuenta;
    internal class Program
    {
        /*En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.
         Resolución*/
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("Luciano Vega", 50000);

            Console.WriteLine(cuenta.Mostrar());

            Console.WriteLine("=============================");

            cuenta.Ingresar(4500.84);

            Console.WriteLine("Se ingreso 4500.84");

            Console.WriteLine(cuenta.Mostrar());

            Console.WriteLine("=============================");

            cuenta.Retirar(20000.50);

            Console.WriteLine("Se retiro 20000.50");

            Console.WriteLine(cuenta.Mostrar());

            Console.WriteLine("=============================");
        }
    }
}