using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ejercicio_I04
{
    /*La cantidad máxima de tinta para todos los bolígrafos será de 100. Generar una constante cantidadTintaMaxima en
    Boligrafo donde se guardará dicho valor.
    Generar los métodos getter GetColor y GetTinta para los correspondientes atributos (sólo retornarán el valor de los mismos).
    Generar un método setter privado SetTinta que valide el nivel de tinta y, si es válido, modifique el valor del atributo tinta.
    El argumento tinta contedrá la cantidad de tinta a agregar o quitar. Podrá ser positivo (cargar tinta) o negativo (gastar tinta).
    Se deberá validar que el nivel de tinta resultante sea mayor o igual a cero y menor o igual a cantidadTintaMaxima.
    Si no es válido, no se deberá modificar el atributo ni realizar ninguna acción.
    El método Recargar colocará la tinta en su nivel máximo. Reutilizar código.
    El método Pintar restará la tinta gastada (reutilizar código). 
    El parámetro gasto representará la cantidad de unidades de tinta a utilizar y utilizará tanta tinta como tenga disponible sin quedar en negativo.
    Utilizando el parámetro dibujo informará el resultado retornando tantos * como unidades de tinta haya gastado, por ejemplo:
    Si no había nada de tinta retornará una cadena de texto vacía.
    Si el nivel de tinta era 10 y la cantidad a gastar 2, entonces retonará **.
    Si el nivel de tinta era 3 y la cantidad a gastar 10, entonces retornará ***.*/


    internal class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color) 
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta () 
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            short tintaFinal = this.tinta;

            if (tinta > 0)
            {
                tintaFinal += tinta;

                if (tintaFinal <= cantidadTintaMaxima)
                {
                    this.tinta = tintaFinal;
                }
            }
            else 
            {
                tintaFinal += tinta;


                if (tintaFinal >= 0) 
                {
                    this.tinta = tintaFinal;
                }
            }
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";
            int dibujar;
            bool retorno =  false;

            if (this.tinta > 0 && gasto > 0)
            {
                if (gasto > this.tinta)
                {
                    dibujar = this.tinta;
                    SetTinta((short)((-1) * this.tinta));
                }
                else
                {
                    dibujar = gasto;
                    SetTinta((short)(gasto * (short)-1));
                }

                for(int i = 0; i < dibujar; i++) 
                {
                    Console.ForegroundColor = this.color;
                    dibujo = dibujo + "*";
                }
                Console.WriteLine($"Se dibujo{dibujar}");


                retorno = true;
            }

            return retorno;
        }

        public void Recargar()
        {
            var recarga = 0;

            recarga = cantidadTintaMaxima - this.tinta;

            SetTinta((short)recarga);

        }
    }
}
