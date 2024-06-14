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
            //string titolo = "";
            //double prezzo = 0;
            //for (int i = 0; i < bindingSource1.Count; i++)
            //{
            //    //double prezzoCorrente = (double)((ModelloManga)bindingSource1.Current).Prezzo;
            //    double prezzoCorrente = Convert.ToDouble(TabellaManga.Rows[i].Cells[3].Value);
            //    if (prezzo < prezzoCorrente)
            //    {
            //        titolo = Convert.ToString(TabellaManga.Rows[i].Cells[1].Value);
            //        prezzo = prezzoCorrente;
            //    }

            //}
            var manga = mangas.MaxBy(x => x.Prezzo);
            MessageBox.Show($"Più costoso {manga.Titolo}","manga più costoso", MessageBoxButtons.OK);
        }

        private void btnMenoCostoso_Click(object sender, EventArgs e)
        {
            //string titolo = convert.tostring(tabellamanga.rows[0].cells[1].value);
            //double prezzo = convert.todouble(tabellamanga.rows[0].cells[3].value);
            //for (int i = 0; i < bindingsource1.count; i++)
            //{
            //    double prezzocorrente = convert.todouble(tabellamanga.rows[i].cells[3].value);
            //    if (prezzo > prezzocorrente)
            //    {
            //        titolo = convert.tostring(tabellamanga.rows[i].cells[1].value);
            //        prezzo = prezzocorrente;
            //    }

            //}
            var manga = mangas.MinBy(x => x.Prezzo);
            MessageBox.Show($"Meno costoso {manga.Titolo}", "manga meno costoso", MessageBoxButtons.OK);
        }
    }
}
