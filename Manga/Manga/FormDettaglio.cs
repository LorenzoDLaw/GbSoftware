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

namespace Manga
{
    public partial class FormDettaglio : Form
    {
        public FormDettaglio(ModelloManga manga)//fa riferimento a :FormDettaglio formdettaglio = new FormDettaglio(manga);
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
            DialogResult= DialogResult.Yes;
            Close();
        }
        private void btnVediTipi(object sender, EventArgs e)
        {
            MessageBox.Show("0 shonen, 1 seinen, 2 isekai, 3 Slice of Life, 4 Kodomo", "Generi", MessageBoxButtons.OK);
        }
    }
}
