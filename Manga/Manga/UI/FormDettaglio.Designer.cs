namespace Manga
{
    partial class FormDettaglio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnSalva = new Button();
            btnAnnulla = new Button();
            txBoxNumPagine = new TextBox();
            bindingSource1 = new BindingSource(components);
            txBoxPrezzo = new TextBox();
            txBoxTipo = new TextBox();
            txBoxTitolo = new TextBox();
            lblNPagine = new Label();
            lblPrezzo = new Label();
            lblTipo = new Label();
            lblTitolo = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(254, 185);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(75, 23);
            btnSalva.TabIndex = 19;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // btnAnnulla
            // 
            btnAnnulla.Location = new Point(163, 185);
            btnAnnulla.Name = "btnAnnulla";
            btnAnnulla.Size = new Size(75, 23);
            btnAnnulla.TabIndex = 18;
            btnAnnulla.Text = "Annulla";
            btnAnnulla.UseVisualStyleBackColor = true;
            btnAnnulla.Click += btnAnnulla_Click;
            // 
            // txBoxNumPagine
            // 
            txBoxNumPagine.DataBindings.Add(new Binding("Text", bindingSource1, "NumeroPagine", true));
            txBoxNumPagine.DataBindings.Add(new Binding("DataContext", bindingSource1, "NumeroPagine", true));
            txBoxNumPagine.DataBindings.Add(new Binding("Tag", bindingSource1, "NumeroPagine", true));
            txBoxNumPagine.Location = new Point(229, 145);
            txBoxNumPagine.Name = "txBoxNumPagine";
            txBoxNumPagine.Size = new Size(100, 23);
            txBoxNumPagine.TabIndex = 17;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Manga);
            // 
            // txBoxPrezzo
            // 
            txBoxPrezzo.DataBindings.Add(new Binding("Text", bindingSource1, "Prezzo", true));
            txBoxPrezzo.DataBindings.Add(new Binding("Tag", bindingSource1, "Prezzo", true));
            txBoxPrezzo.DataBindings.Add(new Binding("DataContext", bindingSource1, "Prezzo", true));
            txBoxPrezzo.Location = new Point(229, 116);
            txBoxPrezzo.Name = "txBoxPrezzo";
            txBoxPrezzo.Size = new Size(100, 23);
            txBoxPrezzo.TabIndex = 16;
            // 
            // txBoxTipo
            // 
            txBoxTipo.DataBindings.Add(new Binding("Text", bindingSource1, "Tipo", true));
            txBoxTipo.DataBindings.Add(new Binding("DataContext", bindingSource1, "Tipo", true));
            txBoxTipo.DataBindings.Add(new Binding("Tag", bindingSource1, "Tipo", true));
            txBoxTipo.Location = new Point(229, 83);
            txBoxTipo.Name = "txBoxTipo";
            txBoxTipo.Size = new Size(100, 23);
            txBoxTipo.TabIndex = 15;
            // 
            // txBoxTitolo
            // 
            txBoxTitolo.DataBindings.Add(new Binding("Text", bindingSource1, "Titolo", true));
            txBoxTitolo.DataBindings.Add(new Binding("DataContext", bindingSource1, "Titolo", true));
            txBoxTitolo.DataBindings.Add(new Binding("Tag", bindingSource1, "Titolo", true));
            txBoxTitolo.Location = new Point(229, 51);
            txBoxTitolo.Name = "txBoxTitolo";
            txBoxTitolo.Size = new Size(100, 23);
            txBoxTitolo.TabIndex = 14;
            // 
            // lblNPagine
            // 
            lblNPagine.AutoSize = true;
            lblNPagine.Location = new Point(163, 148);
            lblNPagine.Name = "lblNPagine";
            lblNPagine.Size = new Size(58, 15);
            lblNPagine.TabIndex = 13;
            lblNPagine.Text = "N. Pagine";
            // 
            // lblPrezzo
            // 
            lblPrezzo.AutoSize = true;
            lblPrezzo.Location = new Point(163, 118);
            lblPrezzo.Name = "lblPrezzo";
            lblPrezzo.Size = new Size(41, 15);
            lblPrezzo.TabIndex = 12;
            lblPrezzo.Text = "Prezzo";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(163, 87);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 11;
            lblTipo.Text = "Tipo";
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Location = new Point(163, 54);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(37, 15);
            lblTitolo.TabIndex = 10;
            lblTitolo.Text = "Titolo";
            // 
            // button1
            // 
            button1.Location = new Point(72, 83);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "elenco";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnVediTipi;
            // 
            // FormDettaglio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(button1);
            Controls.Add(btnSalva);
            Controls.Add(btnAnnulla);
            Controls.Add(txBoxNumPagine);
            Controls.Add(txBoxPrezzo);
            Controls.Add(txBoxTipo);
            Controls.Add(txBoxTitolo);
            Controls.Add(lblNPagine);
            Controls.Add(lblPrezzo);
            Controls.Add(lblTipo);
            Controls.Add(lblTitolo);
            Name = "FormDettaglio";
            Text = "FormDettaglio";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalva;
        private Button btnAnnulla;
        private TextBox txBoxNumPagine;
        private TextBox txBoxPrezzo;
        private TextBox txBoxTipo;
        private TextBox txBoxTitolo;
        private Label lblNPagine;
        private Label lblPrezzo;
        private Label lblTipo;
        private Label lblTitolo;
        private BindingSource bindingSource1;
        private Button button1;
    }
}