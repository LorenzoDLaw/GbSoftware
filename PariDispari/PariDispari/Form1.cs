namespace PariDispari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPari_Click(object sender, EventArgs e)
        {
            String strNum = txBoxNumero.Text;
            int numero = int.Parse(strNum); 
            if ( numero %2 == 0 ) 
            {
                lblPari.Text = "numero pari";
            }
            else
            {
                lblPari.Text = "numero dispari";
            }
        }
    }
}
