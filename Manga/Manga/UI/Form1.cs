using Manga.Repository;
using Manga.UI;
using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Windows.Forms;

namespace Manga
{
    public partial class Form1 : Form
    {
        private MangaRepository _mangaRepository;
        public Form1()
        {
            InitializeComponent();
            _mangaRepository = new MangaRepository();
            bindingSource1.DataSource = _mangaRepository.GetAll();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            PersoneRepository repoPersona = new PersoneRepository();
            Manga manga = new Manga(); //istanzio il modello manga
            FormDettaglio formdettaglio = new FormDettaglio(manga); //vado a richiamare formDettaglio dandogli manga come parametro
            
            var result = formdettaglio.ShowDialog();
            if (result == DialogResult.OK)
            {
                _mangaRepository.NewManga(manga);
                bindingSource1.Add(manga);
            }
        }
        private void btnPiuCostoso_Click(object sender, EventArgs e)
        {
            List<Manga> mangas = new List<Manga>(_mangaRepository.GetAll());
            var manga = mangas.MaxBy(x => x.Prezzo);
            if (mangas.Count != 0)
            {
                MessageBox.Show($"Più costoso {manga.Titolo}", "manga più costoso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("iserire manga alla lista", "attenzione", MessageBoxButtons.OK);
            }
        }


        private void btnMenoCostoso_Click(object sender, EventArgs e)
        {
            List<Manga> mangas = new List<Manga>(_mangaRepository.GetAll());
            var manga = mangas.MinBy(x => x.Prezzo);
            if (mangas.Count != 0)
            {
                MessageBox.Show($"Meno costoso {manga.Titolo}", "manga meno costoso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("iserire manga alla lista", "attenzione", MessageBoxButtons.OK);
            }
        }


        private void TabellaManga_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormDettaglio formdettaglio = new FormDettaglio(bindingSource1.Current as Manga);

            var stato = formdettaglio.ShowDialog();
            if (stato == DialogResult.OK)
            {
                _mangaRepository.UpdateManga(bindingSource1.Current as Manga);
            }
            else if (stato == DialogResult.Abort)
            {
                bindingSource1.DataSource = _mangaRepository.GetAll();
            }

        }


        private void TabellaManga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Delete))
            {
                DialogResult result = MessageBox.Show($"sicuro di voler CANCELLARE l'oggetto", "ATTENZIONE", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Manga modificaManga = new Manga();
                    int Id = (bindingSource1.Current as Manga)!.Id;
                    _mangaRepository.DeleteManga(Id);
                    bindingSource1.DataSource = _mangaRepository.GetAll();
                }
            }
        }


        private void btnPassToPersona_Click(object sender, EventArgs e)
        {
            Persone persone = new Persone();
            FormPersone formPersone = new FormPersone(persone);
            formPersone.Show();
            Hide();
        }


        private void ComboBox1_AbbinaPersona(object sender, EventArgs e)
        {
            PersoneRepository _personeRepository = new PersoneRepository();
            personeBindingSource.DataSource = _personeRepository.GetByNome();
        }
    }
}
    