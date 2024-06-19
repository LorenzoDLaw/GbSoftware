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
using static Manga.EnumManga;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Manga
{
    public partial class FormDettaglio : Form
    {
        public FormDettaglio(Manga manga)//fa riferimento a :FormDettaglio formdettaglio = new FormDettaglio(manga);
        {
            InitializeComponent();
            bindingSource1.DataSource = manga;
        }
        private void btnSalva_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Abort;
            Close();
        }
        private void btnVediTipi(object sender, EventArgs e)
        {
            comBoxTipo.DataSource = Enum.GetValues(typeof(EnumManga));
        }
        private void ComboBox1_AbbinaPersona(object sender, EventArgs e)
        {
            PersoneRepository _personeRepository = new PersoneRepository();
            personeBindingSource.DataSource = _personeRepository.GetByNome();
        }
    }
}
