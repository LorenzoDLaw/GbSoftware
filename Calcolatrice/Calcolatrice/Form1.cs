using System;
using System.Configuration;
using System.Reflection.Metadata.Ecma335;

namespace Calcolatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string ScreenInput { get; set; }
        public string firstInput { get; set; }
        public string secodInput { get; set; }

        double calcolo = 0;

        bool boolRisultato = false;
        private EnumOperazioni _operazioneCorrente;

        private void btnKey1_Click(object sender, EventArgs e)
        {
            if (boolRisultato)
            {
                lblCalcScreen.Text = "";
                boolRisultato = false;
            }
            
            lblCalcScreen.Text = lblCalcScreen.Text + "1";
            ScreenInput = ScreenInput + "1";
        }

        private void btnKey2_Click(object sender, EventArgs e)
        {
            if (boolRisultato)
            {
                lblCalcScreen.Text = "";
                boolRisultato = false;
            }
            lblCalcScreen.Text = lblCalcScreen.Text + "2";
            ScreenInput = ScreenInput + "2";
        }

        private void btnKey3_Click(object sender, EventArgs e)
        {
            if (boolRisultato)
            {
                lblCalcScreen.Text = "";
                boolRisultato = false;
            }
            lblCalcScreen.Text = lblCalcScreen.Text + "3";
            ScreenInput = ScreenInput + "3";
        }

        private void btnKey4_Click(object sender, EventArgs e)
        {
            if (boolRisultato)
            {
                lblCalcScreen.Text = "";
                boolRisultato = false;
            }
            lblCalcScreen.Text = lblCalcScreen.Text + "4";
            ScreenInput = ScreenInput + "4";
        }

        private void btnKey5_Click(object sender, EventArgs e)
        {
            if (boolRisultato)
            {
                lblCalcScreen.Text = "";
                boolRisultato = false;
            }
            lblCalcScreen.Text = lblCalcScreen.Text + "5";
            ScreenInput = ScreenInput + "5";
        }

        private void btnKey6_Click(object sender, EventArgs e)
        {
            if (boolRisultato)
            {
                lblCalcScreen.Text = "";
                boolRisultato = false;
            }
            lblCalcScreen.Text = lblCalcScreen.Text + "6";
            ScreenInput = ScreenInput + "6";
        }

        private void btnKey7_Click(object sender, EventArgs e)
        {
            if (boolRisultato)
            {
                lblCalcScreen.Text = "";
                boolRisultato = false;
            }
            lblCalcScreen.Text = lblCalcScreen.Text + "7";
            ScreenInput = ScreenInput + "7";
        }

        private void btnKey8_Click(object sender, EventArgs e)
        {
            if (boolRisultato)
            {
                lblCalcScreen.Text = "";
                boolRisultato = false;
            }
            lblCalcScreen.Text = lblCalcScreen.Text + "8";
            ScreenInput = ScreenInput + "8";
        }

        private void btnKey9_Click(object sender, EventArgs e)
        {
            if (boolRisultato)
            {
                lblCalcScreen.Text = "";
                boolRisultato = false;
            }
            lblCalcScreen.Text = lblCalcScreen.Text + "9";
            ScreenInput = ScreenInput + "9";
        }

        private void btnKey0_Click(object sender, EventArgs e)
        {
            if (boolRisultato)
            {
                lblCalcScreen.Text = "";
                boolRisultato = false;
            }
            lblCalcScreen.Text = lblCalcScreen.Text + "0";
            ScreenInput = ScreenInput + "0";
        }

        private void btnKeyPiu_Click(object sender, EventArgs e)
        {

            _operazioneCorrente = EnumOperazioni.Somma;
            Somma(firstInput, secodInput);
            /*firstInput = ScreenInput;
            secodInput = lblMiniScreen.Text;
            if (secodInput == "")
            {
                lblMiniScreen.Text = firstInput;
                lblCalcScreen.Text = "";
            }
            else
            {
                double risultato = Double.Parse(secodInput) + Double.Parse(firstInput);
                lblCalcScreen.Text = risultato.ToString();
                lblMiniScreen.Text = risultato .ToString();
            }
            if (lblMiniScreen.Text == "")
            {
                lblMiniScreen.Text = lblCalcScreen.Text;
            }
            lblCalcScreen.Text = "";
            ScreenInput = "";*/

        }

        private void btnKeyMeno_Click(object sender, EventArgs e)
        {

            _operazioneCorrente = EnumOperazioni.Sottrazione;

            firstInput = ScreenInput;
            secodInput = lblMiniScreen.Text;

            if (secodInput == "0")
            {
                lblMiniScreen.Text = firstInput;
                lblCalcScreen.Text = "";
            }
            else
            {
                if (secodInput != "") 
                {
                    double risultato = Double.Parse(secodInput) - Double.Parse(firstInput);
                    lblCalcScreen.Text = risultato.ToString();
                    lblMiniScreen.Text = risultato.ToString();
                }
                
            }
            if (lblMiniScreen.Text == "")
            {
                lblMiniScreen.Text = lblCalcScreen.Text;
            }
            lblCalcScreen.Text = "";
            ScreenInput = "";
        }

        private void btnKeyPer_Click(object sender, EventArgs e)
        {

            _operazioneCorrente = EnumOperazioni.Moltiplicazione;

            firstInput = ScreenInput;
            secodInput = lblMiniScreen.Text;

            if (secodInput == "0")
            {
                lblMiniScreen.Text = firstInput;
                lblCalcScreen.Text = "";
            }
            else
            {
                if (secodInput != "")
                {
                    double risultato = Double.Parse(secodInput) * Double.Parse(firstInput);
                    lblCalcScreen.Text = risultato.ToString();
                    lblMiniScreen.Text = risultato.ToString();
                }

            }
            if (lblMiniScreen.Text == "")
            {
                lblMiniScreen.Text = lblCalcScreen.Text;
            }
            lblCalcScreen.Text = "";
            ScreenInput = "";
        }

        private void btnKeyDiviso_Click(object sender, EventArgs e)
        {

            _operazioneCorrente = EnumOperazioni.Divisione;

            firstInput = ScreenInput;
            secodInput = lblMiniScreen.Text;

            if (secodInput == "0")
            {
                lblMiniScreen.Text = firstInput;
                lblCalcScreen.Text = "";
            }
            else
            {
                if (secodInput != "")
                {
                    double risultato = Double.Parse(secodInput) / Double.Parse(firstInput);
                    lblCalcScreen.Text = risultato.ToString();
                    lblMiniScreen.Text = risultato.ToString();
                }

            }
            if (lblMiniScreen.Text == "")
            {
                lblMiniScreen.Text = lblCalcScreen.Text;
            }
            lblCalcScreen.Text = "";
            ScreenInput = "";
        }

        private void btnKeyEqual_Click(object sender, EventArgs e)
        {
            
            switch (_operazioneCorrente)
            {
                case EnumOperazioni.Somma:
                    Somma(firstInput, secodInput);
                    break;
                case EnumOperazioni.Sottrazione:
                    break;
                case EnumOperazioni.Divisione: 
                    break;
                case EnumOperazioni.Moltiplicazione: 
                    break; 

            }

        }

        private void svuotaInput()
        {
            lblMiniScreen.Text = "";
            firstInput = "";
            secodInput = "";
        }
        private void setInput()
        {
            firstInput = lblCalcScreen.Text;
            secodInput = lblMiniScreen.Text;

            if (secodInput == "" || secodInput == "0")
            {
                lblMiniScreen.Text = firstInput;
                lblCalcScreen.Text = "";
                secodInput = lblMiniScreen.Text;
            }
            if (lblMiniScreen.Text == "")
            {
                lblMiniScreen.Text = lblCalcScreen.Text;
            }
            lblCalcScreen.Text = "";
            ScreenInput = "";
        }
        private void Somma(string firstInput, string secodInput)
        {
            setInput();
            this.firstInput = firstInput;
            this.secodInput = secodInput;
            if(equals(firstInput, secodInput))
            {
                calcolo = Double.Parse(firstInput) + Double.Parse(secodInput);
            }
            lblCalcScreen.Text = calcolo.ToString();

            svuotaInput();
        }

        private void Sottrazione(string firstInput, string secodInput)
        {
            this.firstInput = firstInput;
            this.secodInput = secodInput;
            calcolo = Double.Parse(firstInput) - Double.Parse(secodInput);
            lblCalcScreen.Text = calcolo.ToString();

            svuotaInput();
        }

        private void Divisione(string firstInput, string secodInput)
        {
            this.firstInput = firstInput;
            this.secodInput = secodInput;
            calcolo = Double.Parse(firstInput) / Double.Parse(secodInput);
            lblCalcScreen.Text = calcolo.ToString();

            svuotaInput();
        }

        private void Moltiplicazione(string firstInput, string secodInput)
        {
            this.firstInput = firstInput;
            this.secodInput = secodInput;
            calcolo = Double.Parse(firstInput) * Double.Parse(secodInput);
            lblCalcScreen.Text = calcolo.ToString();

            svuotaInput();
        }

        private bool equals(string firstInput, string secondInpur)
        {
            bool inputPieni = false;
            if (firstInput != "" && secodInput != "0")
                { inputPieni = true; }
            return inputPieni;
        }
    }
}
