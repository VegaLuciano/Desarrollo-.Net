using System.Collections.Generic;

namespace CL_Ejercicio_C03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string opcionRecibida;
            bool comprobar;
            string productoSeleccionado;
            string seguir;
            bool comprobarProducto;

            var maquinaExpendedora = new Dictionary<int, string>()

            {
                {1, "Cocacola"   },
                {2, "Pepsi" },
                {3, "Fanta"  },
                {4, "Sprite" },
                {5, "Cocacola zero"  },
                {6, "Agua mineral" },
                {7, "Aquarius de manzana"  },
                {8, "Aquiarius de pera" },
                {9, "Agua saborizada"  },
                {10, "Gatorade"}
             };

            Console.WriteLine("Los productos de la maquina expendedora son:");

            if (maquinaExpendedora.Count > 0)
            {
                foreach (var producto in maquinaExpendedora)
                {
                    Console.WriteLine(producto.Value);
                }
            }
            else 
            {
                Console.WriteLine("No hay productos");
            }

            Console.WriteLine("=========================================");

            do
            {
                if (maquinaExpendedora.Count > 0)
                {
                    Console.WriteLine("Elija un producto: ");

                    foreach (var producto in maquinaExpendedora)
                    {
                        Console.WriteLine($"{producto.Value} - presione {producto.Key}");
                    }
                }
                else
                {
                    Console.WriteLine("No hay productos");
                }

                Console.Write("Elija una opcion: ");


                opcionRecibida = Console.ReadLine();

                comprobar = int.TryParse(opcionRecibida, out opcion);

                while (!comprobar)
                {
                    Console.Write("Error, Elija una opcion: ");
                    opcionRecibida = Console.ReadLine();
                    comprobar = int.TryParse(opcionRecibida, out opcion);
                }

                comprobarProducto = maquinaExpendedora.TryGetValue(opcion, out productoSeleccionado);
                if (comprobarProducto)
                {
                    Console.WriteLine($"Usted elijió:  |{productoSeleccionado}| ");
                }
                else 
                {
                    Console.WriteLine("Error, pocision incorrecta");
                }


                Console.WriteLine("=========================================");

                if (maquinaExpendedora.Count > 0)
                {
                    if (maquinaExpendedora.Remove(opcion))
                    {
                        Console.WriteLine("Lista de productos Actualizada: ");

                        foreach (var producto in maquinaExpendedora)
                        {
                            Console.WriteLine(producto.Value);
                        }

                        Console.WriteLine("=========================================");
                    }
                }
                else
                {
                    Console.WriteLine("No hay productos");
                }

                Console.WriteLine("Si desea continuar presione - s ");

                seguir = Console.ReadLine();

            } while (seguir == "S" || seguir == "s");

            Console.WriteLine("Fin de la ejecucion");
        }
    }
}