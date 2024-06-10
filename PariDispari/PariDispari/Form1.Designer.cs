namespace PariDispari
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
            btnPari = new Button();
            txBoxNumero = new TextBox();
            lblPari = new Label();
            SuspendLayout();
            // 
            // btnPari
            // 
            btnPari.Location = new Point(255, 62);
            btnPari.Name = "btnPari";
            btnPari.Size = new Size(102, 23);
            btnPari.TabIndex = 0;
            btnPari.Text = "pari o dispari";
            btnPari.UseVisualStyleBackColor = true;
            btnPari.Click += btnPari_Click;
            // 
            // txBoxNumero
            // 
            txBoxNumero.Location = new Point(268, 33);
            txBoxNumero.Name = "txBoxNumero";
            txBoxNumero.Size = new Size(75, 23);
            txBoxNumero.TabIndex = 1;
            // 
            // lblPari
            // 
            lblPari.AutoSize = true;
            lblPari.Location = new Point(268, 101);
            lblPari.Name = "lblPari";
            lblPari.Size = new Size(38, 15);
            lblPari.TabIndex = 2;
            lblPari.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 141);
            Controls.Add(lblPari);
            Controls.Add(txBoxNumero);
            Controls.Add(btnPari);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPari;
        private TextBox txBoxNumero;
        private Label lblPari;
    }
}
