using TranformarBinarios;
namespace Prueba_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            string numeroRecibido;
            bool comprobar;
            int numeroDecimal;
            string numeroBinario;

            numeroRecibido = txtBinario.Text;
            comprobar = int.TryParse(numeroRecibido, out numeroDecimal);

            if (!comprobar)
            {
                numeroBinario = Conversor.ConvertirDecimalABinario(numeroDecimal);
                txtResultadoDec.Text = numeroBinario;
            }
            else
            {
                MessageBox.Show("Ingrese el numero de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}