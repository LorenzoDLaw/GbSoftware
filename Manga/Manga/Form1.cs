namespace Manga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            FormDettaglio formdettaglio = new FormDettaglio();
            formdettaglio.Show();

        }
        private void btnPiuCostoso_Click(object sender, EventArgs e)
        {
        }

        private void btnMenoCostoso_Click(object sender, EventArgs e)
        {

        }
        public void mangaLista() 
        {

        }
    }
}
