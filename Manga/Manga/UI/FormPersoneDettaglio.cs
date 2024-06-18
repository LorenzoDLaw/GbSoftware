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
    public partial class FormPersoneDettaglio : System.Windows.Forms.Form
    {
        public FormPersoneDettaglio(Persone persona)
        {
            InitializeComponent();
            bindingSource2.DataSource = persona;
        }
        private void btnSalva_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }
    }
}
