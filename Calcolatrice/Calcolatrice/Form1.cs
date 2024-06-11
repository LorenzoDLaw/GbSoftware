using System;
using System.Configuration;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace Calcolatrice
{
    public partial class Form1 : Form
    {
        public string ScreenInput { get; set; }
        public string FirstInput { get; set; }
        public double num1 { get; set; }
        public double num2 { get; set; }

        double calcolo = 0;

        private EnumOperazioni _operazioneCorrente;
            

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetValue(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                var text = (sender as Button)?.Text;
                if(lblCalcScreen.Text.Equals("0")) 
                {
                    lblCalcScreen.Text = text;
                    ScreenInput += text;
                }
                else
                {
                    lblCalcScreen.Text = lblCalcScreen.Text + text;
                    ScreenInput += text;
                }
                
            }
            // DlogResult result = MessageBox.Show((sender as Button).Text, "Provaaaaaaaaa!", MessageBoxButtons.OK);
        }
        private void btnKeyOperatore(object sender, EventArgs e)
        {
            setInput();
            switch ((sender as Button)?.Text)
            {
                case "+":
                    setInput();
                    _operazioneCorrente = EnumOperazioni.Somma;
                    Somma(FirstInput);
                    break;
                case "-":
                    setInput();
                    _operazioneCorrente = EnumOperazioni.Sottrazione;
                    Sottrazione(FirstInput);
                    break;
                case "/":
                    setInput();
                    _operazioneCorrente = EnumOperazioni.Divisione;
                    Divisione(FirstInput);
                    break;
                case "x":
                    setInput();
                    _operazioneCorrente = EnumOperazioni.Moltiplicazione;
                    Moltiplicazione(FirstInput);
                    break;
            }            
        }

        private void btnKeyEqual_Click(object sender, EventArgs e)
        {
            setInput();
            switch (_operazioneCorrente)
            {
                case EnumOperazioni.Somma:
                    Somma(FirstInput);
                    break;
                case EnumOperazioni.Sottrazione:
                    Sottrazione(FirstInput);
                    break;
                case EnumOperazioni.Divisione:
                    Divisione(FirstInput);
                    break;
                case EnumOperazioni.Moltiplicazione:
                    Moltiplicazione(FirstInput);
                    break;
            }

        }

        private void svuotaInput()
        {
            ScreenInput = "";
            lblCalcScreen.Text = "0";
            num1 = 0;
        }
        private void setInput()
        {
            FirstInput = lblCalcScreen.Text;
            if(FirstInput != "")
            {
                num1 = Double.Parse(FirstInput);
            }
        }
        private void Somma(string firstInput)
        {
            if (lblMiniScreen.Text == "0" || lblMiniScreen.Text == "")
            {
                lblMiniScreen.Text = lblCalcScreen.Text;
                calcolo = num1;
                lblCalcScreen.Text = "";
            }
            else
            {
                calcolo += num1;
                lblMiniScreen.Text = calcolo.ToString();
            }
            if (lblCalcScreen.Text == "0")
            {
                lblMiniScreen.Text = lblMiniScreen.Text + "+" ;
            }
            svuotaInput();
        }

        private void Sottrazione(string firstInput)
        {
            if (lblMiniScreen.Text == "0" || lblMiniScreen.Text == "")
            {
                lblMiniScreen.Text = lblCalcScreen.Text;
                calcolo = num1; 
                lblCalcScreen.Text = "";
            }
            else
            {
                calcolo -= num1;
                lblMiniScreen.Text = calcolo.ToString();
                num2 = calcolo;
            }
            if (lblCalcScreen.Text == "0")
            {
                lblMiniScreen.Text = lblMiniScreen.Text+="-";
            }
            svuotaInput();
        }
        private void Divisione(string firstInput)
        {
            {
                //Console.WriteLine("second" + secodInput, "first" + firstInput);
                if (lblMiniScreen.Text == "0" || lblMiniScreen.Text == "")
                {
                    lblMiniScreen.Text = lblCalcScreen.Text;
                    calcolo = num1;
                    lblCalcScreen.Text = "";
                }
                else
                {
                    if (num1 == 0) { num1 = 1; }
                    calcolo /= num1;
                    lblMiniScreen.Text = calcolo.ToString();
                }
                if (lblCalcScreen.Text == "0")
                {
                    lblMiniScreen.Text = lblMiniScreen.Text + "/";
                }
                svuotaInput();
            }
        }
        private void Moltiplicazione(string firstInput)
        {
            {
                //Console.WriteLine("second" + secodInput, "first" + firstInput);
                if (lblMiniScreen.Text == "0" || lblMiniScreen.Text == "")
                {
                    lblMiniScreen.Text = lblCalcScreen.Text;
                    calcolo = num1;
                    lblCalcScreen.Text = "";
                }
                else
                {
                    if(num1 == 0) { num1 = 1; }
                    calcolo *= num1;
                    lblMiniScreen.Text = calcolo.ToString();
                }
                if (lblCalcScreen.Text == "0")
                {
                    lblMiniScreen.Text = lblMiniScreen.Text + "x";
                }
                svuotaInput();
            }
        }

        private void equals(string firstInput, string secondInpur)
        {
            switch (_operazioneCorrente)
            {
                case EnumOperazioni.Somma:
                    Somma(firstInput);
                    break;
                case EnumOperazioni.Sottrazione:
                    Sottrazione(firstInput);
                    break;
                case EnumOperazioni.Divisione:
                    Divisione(firstInput);
                    break;
                case EnumOperazioni.Moltiplicazione:
                    Moltiplicazione(firstInput);
                    break;
            }
        }
    }
}
