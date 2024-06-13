using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Windows.Forms;

namespace Manga
{
    public partial class Form1 : Form
    {
        List<ModelloManga> mangas = new List<ModelloManga>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            ModelloManga manga = new ModelloManga(); //istanzio il modello manga
            FormDettaglio formdettaglio = new FormDettaglio(manga); //vado a richiamare formDettaglio dandogli manga come parametro
            var result = formdettaglio.ShowDialog();
            if (result == DialogResult.OK)
            {
                bindingSource1.Add(manga);
                mangas.Add(manga);
            }
        }
        private void btnPiuCostoso_Click(object sender, EventArgs e)
        {
            string titolo = "";
            double prezzo = 0;
            for (int i = 0; i < bindingSource1.Count; i++)
            {
                double prezzoCorrente = (double)((ModelloManga)bindingSource1.Current).Prezzo;
                //double prezzoCorrente = Convert.ToDouble(TabellaManga.Rows[i].Cells[2].Value);
                if (prezzo < prezzoCorrente)
                {
                    titolo = Convert.ToString(TabellaManga.Rows[i].Cells[1].Value);
                    prezzo = prezzoCorrente;
                }
                  
            }
            MessageBox.Show($"Più costoso {titolo}","manga più costoso", MessageBoxButtons.OK);
        }

        private void btnMenoCostoso_Click(object sender, EventArgs e)
        {
            string titolo = "";
            double prezzo = Convert.ToDouble(TabellaManga.Rows[0].Cells[2].Value);
            for (int i = 0; i < bindingSource1.Count; i++)
            {
                double prezzoCorrente = (double)((ModelloManga)bindingSource1.Current).Prezzo;
                //double prezzoCorrente = Convert.ToDouble(TabellaManga.Rows[i].Cells[2].Value);
                if (prezzo > prezzoCorrente)
                {
                    titolo = Convert.ToString(TabellaManga.Rows[i].Cells[1].Value);
                    prezzo = prezzoCorrente;
                }

            }
            MessageBox.Show($"Meno costoso {titolo}", "manga meno costoso", MessageBoxButtons.OK);
        }
    }
}
