using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    /*La clase Punto debe tener:
    Dos atributos privados con acceso de sólo lectura (sólo con getters), que serán las coordenadas del punto.
    Un constructor que reciba los parámetros x e y.*/

    internal class Punto
    {
        private int x;
        private int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX() { return x; }

        public int GetY() { return y; }
    }
}
