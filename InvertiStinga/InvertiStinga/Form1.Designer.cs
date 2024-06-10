namespace InvertiStinga
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
            lblTesto = new Label();
            txBoxParola = new TextBox();
            btnInverti = new Button();
            SuspendLayout();
            // 
            // lblTesto
            // 
            lblTesto.AutoSize = true;
            lblTesto.Location = new Point(47, 98);
            lblTesto.Name = "lblTesto";
            lblTesto.Size = new Size(0, 15);
            lblTesto.TabIndex = 0;
            // 
            // txBoxParola
            // 
            txBoxParola.Location = new Point(47, 27);
            txBoxParola.Name = "txBoxParola";
            txBoxParola.Size = new Size(100, 23);
            txBoxParola.TabIndex = 1;
            // 
            // btnInverti
            // 
            btnInverti.Location = new Point(47, 56);
            btnInverti.Name = "btnInverti";
            btnInverti.Size = new Size(90, 23);
            btnInverti.TabIndex = 2;
            btnInverti.Text = "Inveti parola";
            btnInverti.UseVisualStyleBackColor = true;
            btnInverti.Click += btnInverti_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 304);
            Controls.Add(btnInverti);
            Controls.Add(txBoxParola);
            Controls.Add(lblTesto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTesto;
        private TextBox txBoxParola;
        private Button btnInverti;
    }
}
