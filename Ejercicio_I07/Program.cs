namespace Ejercicio_I07
{
    internal class Program
    {
        /*Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas
        en el mes de N cantidad de empleados de una fábrica.
        Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad
        de horas trabajadas), hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas 
        operaciones restarle el 13% en concepto de descuentos.
        Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a 
        cobrar neto de todos los empleados ingresados.*/
        static void Main(string[] args)
        {
            int valorPorHora;
            string nombre;
            int antiguedadAños;
            int cantidadHorasTrabajadas;
            string comprobarDatos;
            bool comprobar;
            int validacionNombre;
            double totalBruto = 0;
            double totalNeto = 0;
            string seguirIngresando;

            do
            {
                Console.WriteLine("---------- CALCULE SU RECIBO DE SUELDO ----------");
                Console.WriteLine("Ingrese el valor por hora:");
                comprobarDatos = Console.ReadLine();
                comprobar = int.TryParse(comprobarDatos, out valorPorHora);

                while (!comprobar || valorPorHora < 1)
                {
                    Console.WriteLine("Error, Ingrese el valor por hora: ");
                    comprobarDatos = Console.ReadLine();
                    comprobar = int.TryParse(comprobarDatos, out valorPorHora);
                }

                Console.WriteLine("Ingrese el nombre y el apellido");
                nombre = Console.ReadLine();
                comprobar = int.TryParse(nombre, out validacionNombre);

                while (comprobar == true)
                {
                    Console.WriteLine("Error, Ingrese el nombre y el apellido");
                    nombre = Console.ReadLine();
                    comprobar = int.TryParse(nombre, out validacionNombre);
                }

                Console.WriteLine("Ingrese su antiguedad en años:");
                comprobarDatos = Console.ReadLine();
                comprobar = int.TryParse(comprobarDatos, out antiguedadAños);

                while (!comprobar || antiguedadAños < 1)
                {
                    Console.WriteLine("Error, Ingrese su antiguedad en años:");
                    comprobarDatos = Console.ReadLine();
                    comprobar = int.TryParse(comprobarDatos, out antiguedadAños);
                }
                    
                Console.WriteLine("Ingrese la cantidad de horas trabajadas en el mes:");
                comprobarDatos = Console.ReadLine();
                comprobar = int.TryParse(comprobarDatos, out cantidadHorasTrabajadas);

                while (!comprobar || cantidadHorasTrabajadas < 1)
                {
                    Console.WriteLine("Error,Ingrese la cantidad de horas trabajadas en el mes:");
                    comprobarDatos = Console.ReadLine();
                    comprobar = int.TryParse(comprobarDatos, out cantidadHorasTrabajadas);
                }

                totalBruto += valorPorHora * cantidadHorasTrabajadas;   
                totalBruto += antiguedadAños * 150;
                totalNeto = totalBruto - (totalBruto * 0.13) ;

                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Su antiguedad es de {antiguedadAños} años");
                Console.WriteLine($"El valor por hora es {valorPorHora}");
                Console.WriteLine($"El Total bruto es: {totalBruto}");
                Console.WriteLine($"El Total neto con un descueto del 13% es: {totalNeto}");
                Console.WriteLine("----------------------------------------------------------------");


                Console.WriteLine("¿Desea seguir ingresando trabajadores?");
                Console.WriteLine("continuar - salir");
                seguirIngresando = Console.ReadLine();

                while (seguirIngresando != "continuar" && seguirIngresando != "salir" )
                {
                    Console.WriteLine("Error: Ingrese una ipcion valida ¿Desea seguir ingresando trabajadores?");
                    Console.WriteLine("continuar - salir");
                    seguirIngresando = Console.ReadLine();
                }

            } while (seguirIngresando != "salir");


        }
    }
}