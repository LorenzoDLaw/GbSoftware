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
        public FormPersone(Persone persona)
        {
            InitializeComponent();
            _personeRepository = new PersoneRepository();
            bindingSource2.DataSource = _personeRepository.GetAll();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Persone persona = new Persone(); //istanzio il modello manga
            FormPersoneDettaglio formdettaglio = new FormPersoneDettaglio(persona); //vado a richiamare formDettaglio dandogli manga come parametro
            var result = formdettaglio.ShowDialog();
            if (result == DialogResult.OK)
            {
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
