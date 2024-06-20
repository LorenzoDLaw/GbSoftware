using Manga.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manga.UI
{
    public partial class FormPersone : System.Windows.Forms.Form
    {
        private PersoneRepository _personeRepository;
        private MangaRepository _mangaRepository;
        public FormPersone(Persone persona)
        {
            //iniaializzo il processo 
            InitializeComponent();
            _personeRepository = new PersoneRepository(); // valorizzo _personeRepositoy 
            bindingSource2.DataSource = _personeRepository.GetAll();// aggiorna la bindingSource2

        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            //Passo alla form dettaglio e aggiungo un nuovo manga
            Persone persona = new Persone(); //istanzio il modello manga
            FormPersoneDettaglio formdettaglio = new FormPersoneDettaglio(persona); //vado a richiamare formDettaglio dandogli manga come parametro
            var result = formdettaglio.ShowDialog();
            if (result == DialogResult.OK)
            {
                //se il risulato da ok aggionro il tutto
                _personeRepository.NewPersona(persona);
                bindingSource2.Add(persona);
            }
        }


        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            DialogResult = DialogResult.Abort;
            form.Show();
            Close();
        }


        private void TabellaManga_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //va a modificare il record con un doppio clik sulla casella su cui è effettuato
            FormPersoneDettaglio formdettaglio = new FormPersoneDettaglio(bindingSource2.Current as Persone);

            var stato = formdettaglio.ShowDialog();
            if (stato == DialogResult.OK)
            {
                _personeRepository.UpdatePersona(bindingSource2.Current as Persone);
            }
            else if (stato == DialogResult.Abort)
            {
                bindingSource2.DataSource = _personeRepository.GetAll();
            }

        }



        private void TabellaManga_KeyDown(object sender, KeyEventArgs e)
        {
            //permette di eliminare il manga selezionato
            if (e.KeyCode.Equals(Keys.Delete))
            {
                DialogResult result = MessageBox.Show($"sicuro di voler CANCELLARE l'oggetto", "ATTENZIONE", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Manga modificaManga = new Manga();
                    int Id = (bindingSource2.Current as Persone)!.Id;
                    _personeRepository.DeletePersona(Id);
                    bindingSource2.DataSource = _personeRepository.GetAll();
                }
            }
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //ottieni i manga della persona selezionata
            int IdPersona = (bindingSource2.Current as Persone)!.Id;
            _mangaRepository = new MangaRepository();
            mangaBindingSource.DataSource = _mangaRepository.GetById(IdPersona);
        }
    }
}
