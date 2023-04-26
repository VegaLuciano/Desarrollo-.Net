using System.Text;

namespace CL_EnciendanSusMotores
{
    /*Al generar un auto se cargará el atributo enCompetencia como falso. Inicializar cantidadCombustible y vueltasRestantes en 0.
    Dos autos serán iguales si los atributos número y escuderia son iguales.
    Realizar los métodos getters y setters para cantidadCombustible , enCompetencia y vueltasRestantes.*/

    public class AutoF1
    {
        private short _cantidadCombustible;
        private bool _enCompetencia;
        private string? _escuderia;
        private short _numero;
        private short _vueltasRestantes;

        public AutoF1( short numero, string? escuderia) : this()
        {
            _escuderia = escuderia;
            _numero = numero;            
        }

        AutoF1() 
        {
            this._enCompetencia = false;
            this._cantidadCombustible = 0;
            this._vueltasRestantes = 0;
        }

        public short CantidadCombustible 
        { 
            get { return this._cantidadCombustible; }
            set { this._cantidadCombustible = value ; } 
        }

        public bool EnCompetencia 
        {
            get { return this._enCompetencia; }
            set { this._enCompetencia = value; }
        }

        public short VueltasRestantes 
        {
            get { return this._vueltasRestantes; }
            set {this._vueltasRestantes = value; } 
        }

        public string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"numero: {_numero}");
            sb.AppendLine($"escuderia: {_escuderia}");
            sb.AppendLine($"vueltas restantes: {_vueltasRestantes}");
            sb.Append($"en competencia: ");
            if (_enCompetencia)
            {
                sb.AppendLine("Compite");
            }
            else 
            {
                sb.AppendLine("No compite");
            }
   
            sb.AppendLine($"cantidad de combustible: {_cantidadCombustible}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarDatos();
        }

        public static bool operator ==(AutoF1 unAuto, AutoF1 otroAuto) 
        {
            return unAuto._numero == otroAuto._numero && unAuto._escuderia == otroAuto._escuderia;
        }
        public static bool operator !=(AutoF1 unAuto, AutoF1 otroAuto)
        {
            return !(unAuto == otroAuto);
        }
    }
}