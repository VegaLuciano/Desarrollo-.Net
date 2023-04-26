using WF_Ingresante;
namespace WF_Ejercicio_I01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string genero;
            string[] cursos = { "", "", "" };

            if (rdoFemenino.Checked)
            {
                genero = rdoFemenino.Text;
            }
            else
            {
                if (rdoMasculino.Checked)
                {
                    genero = rdoMasculino.Text;
                }
                else
                {
                    genero = rdoNobinario.Text;
                }
            }

            if (chkC.Checked)
            {
                cursos[0] = chkC.Text;
            }
            if (chkCSharp.Checked)
            {
                cursos[1] = chkCSharp.Text;
            }
            if (chkJavascript.Checked)
            {
                cursos[2] = chkJavascript.Text;
            }
            
            Ingresante ingresante = new Ingresante(txtNombre.Text, txtDireccion.Text, genero,
                lstPais.Text, cursos, (int)npdEdad.Value);

            MessageBox.Show(ingresante.ToString());
            
        }
    }
}