using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manga
{
    public partial class FormDettaglio : Form
    {
        public FormDettaglio()
        {
            InitializeComponent();
            bindingSource1.DataSource = new ModelloManga()
            {
                Titolo = "One piece"
            };
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
