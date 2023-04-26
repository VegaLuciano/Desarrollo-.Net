using TranformarBinarios;
namespace WF_Ejercicio_C03
{
    /*Implementarlo de tal forma que al ingresar un valor válido en la primer casilla
     (txtBinario y txtDecimal respectivamente) y presionar el botón del medio (btnBinToDec y btnDecToBin) 
     el resultado de la conversión se vea reflejado en las casillas de la derecha
     (txtResultadoDec y txtResultadoBin), las cuales no podrán ser editadas/escritas por el usuario.*/

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBinario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            string numeroRecibido;
            bool comprobar;
            int numeroDecimal;
            int numeroBinario;

            numeroRecibido = txtBinario.Text;
            comprobar = int.TryParse(numeroRecibido, out numeroBinario);

            if (comprobar)
            {
                numeroDecimal = Conversor.ConvertirBinarioADecimal(numeroBinario);
                txtResultadoDec.Text = numeroDecimal.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese el numero de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            bool comprobar;
            string numeroRecibido;
            string numeroBinario;
            int numeroDecimal;

            numeroRecibido =  txtDecimal.Text;
            comprobar = int.TryParse(numeroRecibido, out numeroDecimal);

            if (comprobar)
            {
                numeroBinario = Conversor.ConvertirDecimalABinario(numeroDecimal);
                txtResultadoBin.Text = numeroBinario;
            }
            else
            {
                MessageBox.Show("Ingrese el numero de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}