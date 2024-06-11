using System.Windows.Forms;

namespace Temperatura
{
    public partial class Form1 : Form
    {
        public float[] ListTemperature {  get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserici_Click(object sender, EventArgs e)
        {
            listBoxTemperature.Items.Add(txBoxTemperatura.Text);
            txBoxTemperatura.Text = "0";
        }

        private void btnGetDati_Click(object sender, EventArgs e)
        {
            int len = listBoxTemperature.Items.Count;
            ListTemperature = new float[len];
            float min=1000;
            float max=0;
            float media;
            for (int i = 0; i < len; i++)
            {
                ListTemperature[i] = float.Parse(listBoxTemperature.GetItemText(i));
                if (max < ListTemperature[i]) { max = ListTemperature[i]; }
                if (min > ListTemperature[i]) { min = ListTemperature[i]; }
                media += ListTemperature[i];
            }
            media = media / len;
            string stMedia = media.ToString();
            string stMin = min.ToString();  
            string stMax = max.ToString();  
            DialogResult result = MessageBox.Show(stMedia, "Dati!", MessageBoxButtons.OK);
        }

        private void btnSvuota_Click(object sender, EventArgs e)
        {

        }
    }
}
