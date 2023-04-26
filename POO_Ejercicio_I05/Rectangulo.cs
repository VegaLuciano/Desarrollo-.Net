using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    /*La clase Rectangulo:
    Tiene los atributos de tipo Punto: vertice1, vertice2, vertice3 y vertice4 (que corresponden a los cuatro vértices del rectángulo).
    La base de todos los rectángulos de esta clase será siempre horizontal. 
    El constructor para calculará los vértices 2 y 4 del rectángulo a partir de los vértices 1 y 3. 
    Utilizar el método Abs de la clase Math que retorna el valor absoluto de un número y será necesario para obtener la distancia entre puntos.
    Realizar los métodos getters para los atributos privados area y perimetro.
    El área (base * altura) y el perímetro ((base + altura) / 2) 
    se deberán calcular sólo una vez cuando se llame por primera vez a su correspondiente método getter.
    En las siguientes invocaciones de dichos métodos se deberá retornar siempre el valor calculado anteriormente.*/

    internal class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3) 
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
        }

    }
}
