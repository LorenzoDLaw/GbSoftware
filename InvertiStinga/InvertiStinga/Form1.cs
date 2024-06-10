using System.Numerics;

namespace InvertiStinga
{
    public partial class Form1 : Form
    {
        String parolaInvertita = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInverti_Click(object sender, EventArgs e)
        {
            lblTesto.Text = "";
            String paorla = txBoxParola.Text;
            char[] x = paorla.ToCharArray();
            for (int i = x.Length-1; i >= 0; i--)
            {
                parolaInvertita += x[i];
            }
            lblTesto.Text = parolaInvertita;
        }
    }
}
