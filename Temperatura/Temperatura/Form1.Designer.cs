namespace Temperatura
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxTemperature = new ListBox();
            txBoxTemperatura = new TextBox();
            btnInserici = new Button();
            btnSvuota = new Button();
            btnGetDati = new Button();
            SuspendLayout();
            // 
            // listBoxTemperature
            // 
            listBoxTemperature.FormattingEnabled = true;
            listBoxTemperature.ItemHeight = 15;
            listBoxTemperature.Location = new Point(117, 135);
            listBoxTemperature.Name = "listBoxTemperature";
            listBoxTemperature.Size = new Size(120, 94);
            listBoxTemperature.TabIndex = 0;
            // 
            // txBoxTemperatura
            // 
            txBoxTemperatura.Location = new Point(260, 135);
            txBoxTemperatura.Name = "txBoxTemperatura";
            txBoxTemperatura.Size = new Size(100, 23);
            txBoxTemperatura.TabIndex = 1;
            // 
            // btnInserici
            // 
            btnInserici.Location = new Point(366, 135);
            btnInserici.Name = "btnInserici";
            btnInserici.Size = new Size(75, 23);
            btnInserici.TabIndex = 2;
            btnInserici.Text = "Inserisci";
            btnInserici.UseVisualStyleBackColor = true;
            btnInserici.Click += btnInserici_Click;
            // 
            // btnSvuota
            // 
            btnSvuota.Location = new Point(366, 180);
            btnSvuota.Name = "btnSvuota";
            btnSvuota.Size = new Size(75, 23);
            btnSvuota.TabIndex = 3;
            btnSvuota.Text = "svuota lista";
            btnSvuota.UseVisualStyleBackColor = true;
            btnSvuota.Click += btnSvuota_Click;
            // 
            // btnGetDati
            // 
            btnGetDati.Location = new Point(260, 180);
            btnGetDati.Name = "btnGetDati";
            btnGetDati.Size = new Size(75, 23);
            btnGetDati.TabIndex = 4;
            btnGetDati.Text = "prendi dati";
            btnGetDati.UseVisualStyleBackColor = true;
            btnGetDati.Click += btnGetDati_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGetDati);
            Controls.Add(btnSvuota);
            Controls.Add(btnInserici);
            Controls.Add(txBoxTemperatura);
            Controls.Add(listBoxTemperature);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTemperature;
        private TextBox txBoxTemperatura;
        private Button btnInserici;
        private Button btnSvuota;
        private Button btnGetDati;
    }
}
