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
                mangas.Add(manga);
                bindingSource1.Add(manga);
            }
        }
        private void btnPiuCostoso_Click(object sender, EventArgs e)
        {
            var manga = mangas.MaxBy(x => x.Prezzo);
            MessageBox.Show($"Più costoso {manga.Titolo}", "manga più costoso", MessageBoxButtons.OK);
        }

        private void btnMenoCostoso_Click(object sender, EventArgs e)
        {
            var manga = mangas.MinBy(x => x.Prezzo);
            MessageBox.Show($"Meno costoso {manga.Titolo}", "manga meno costoso", MessageBoxButtons.OK);
        }

        private void TabellaManga_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            ModelloManga modificaManga = new ModelloManga();
            modificaManga.Titolo = (bindingSource1.Current as ModelloManga)!.Titolo;
            modificaManga.Tipo = (bindingSource1.Current as ModelloManga)!.Tipo;
            modificaManga.Prezzo = (bindingSource1.Current as ModelloManga)!.Prezzo;
            modificaManga.NumeroPagine = (bindingSource1.Current as ModelloManga)!.NumeroPagine;
            FormDettaglio formdettaglio = new FormDettaglio(modificaManga);
            var stato = formdettaglio.ShowDialog();
            if (stato == DialogResult.OK)
            {
                mangas.Add(modificaManga);
                mangas.Remove(bindingSource1.Current as ModelloManga);
                bindingSource1.DataSource = mangas;
            }
            else if (stato == DialogResult.Yes)
            {
                bindingSource1.DataSource = mangas;
            }

        }
        private void TabellaManga_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show($"{e.KeyData}", "caio", MessageBoxButtons.OK);
            if (e.KeyCode.Equals(Keys.Delete))
            {
                DialogResult result = MessageBox.Show($"cancella", "caio", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //MessageBox.Show($"{valIndex}", "caio", MessageBoxButtons.OK);
                    mangas.Remove(bindingSource1.Current as ModelloManga);
                    bindingSource1.RemoveCurrent();
                }     
            }
        }
    }
}
