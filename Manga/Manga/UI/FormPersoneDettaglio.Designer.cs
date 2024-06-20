namespace Manga.UI
{
    partial class FormPersoneDettaglio
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
            bindingSource2 = new BindingSource(components);
            txBoxPrezzo = new TextBox();
            txBoxTipo = new TextBox();
            txBoxTitolo = new TextBox();
            lblNPagine = new Label();
            lblPrezzo = new Label();
            lblTipo = new Label();
            lblTitolo = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            SuspendLayout();
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(286, 188);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(90, 23);
            btnSalva.TabIndex = 30;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // btnAnnulla
            // 
            btnAnnulla.Location = new Point(185, 188);
            btnAnnulla.Name = "btnAnnulla";
            btnAnnulla.Size = new Size(90, 23);
            btnAnnulla.TabIndex = 29;
            btnAnnulla.Text = "Annulla";
            btnAnnulla.UseVisualStyleBackColor = true;
            btnAnnulla.Click += btnAnnulla_Click;
            // 
            // txBoxNumPagine
            // 
            txBoxNumPagine.DataBindings.Add(new Binding("Text", bindingSource2, "Anno", true));
            txBoxNumPagine.Location = new Point(251, 148);
            txBoxNumPagine.Name = "txBoxNumPagine";
            txBoxNumPagine.Size = new Size(120, 23);
            txBoxNumPagine.TabIndex = 28;
            // 
            // bindingSource2
            // 
            bindingSource2.DataSource = typeof(Persone);
            // 
            // txBoxPrezzo
            // 
            txBoxPrezzo.DataBindings.Add(new Binding("Text", bindingSource2, "Citta", true));
            txBoxPrezzo.DataBindings.Add(new Binding("Tag", bindingSource2, "Citta", true));
            txBoxPrezzo.DataBindings.Add(new Binding("DataContext", bindingSource2, "Citta", true));
            txBoxPrezzo.Location = new Point(251, 119);
            txBoxPrezzo.Name = "txBoxPrezzo";
            txBoxPrezzo.Size = new Size(120, 23);
            txBoxPrezzo.TabIndex = 27;
            // 
            // txBoxTipo
            // 
            txBoxTipo.DataBindings.Add(new Binding("DataContext", bindingSource2, "Cognome", true));
            txBoxTipo.DataBindings.Add(new Binding("Text", bindingSource2, "Cognome", true));
            txBoxTipo.DataBindings.Add(new Binding("Tag", bindingSource2, "Cognome", true));
            txBoxTipo.Location = new Point(251, 86);
            txBoxTipo.Name = "txBoxTipo";
            txBoxTipo.Size = new Size(120, 23);
            txBoxTipo.TabIndex = 26;
            // 
            // txBoxTitolo
            // 
            txBoxTitolo.DataBindings.Add(new Binding("Text", bindingSource2, "Nome", true));
            txBoxTitolo.DataBindings.Add(new Binding("Tag", bindingSource2, "Nome", true));
            txBoxTitolo.DataBindings.Add(new Binding("DataContext", bindingSource2, "Nome", true));
            txBoxTitolo.Location = new Point(251, 54);
            txBoxTitolo.Name = "txBoxTitolo";
            txBoxTitolo.Size = new Size(120, 23);
            txBoxTitolo.TabIndex = 25;
            // 
            // lblNPagine
            // 
            lblNPagine.AutoSize = true;
            lblNPagine.Location = new Point(185, 151);
            lblNPagine.Name = "lblNPagine";
            lblNPagine.Size = new Size(36, 15);
            lblNPagine.TabIndex = 24;
            lblNPagine.Text = "Anno";
            // 
            // lblPrezzo
            // 
            lblPrezzo.AutoSize = true;
            lblPrezzo.Location = new Point(185, 121);
            lblPrezzo.Name = "lblPrezzo";
            lblPrezzo.Size = new Size(32, 15);
            lblPrezzo.TabIndex = 23;
            lblPrezzo.Text = "Citta";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(185, 90);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(60, 15);
            lblTipo.TabIndex = 22;
            lblTipo.Text = "Cognome";
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Location = new Point(185, 57);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(40, 15);
            lblTitolo.TabIndex = 21;
            lblTitolo.Text = "Nome";
            // 
            // FormPersoneDettaglio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 261);
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
            Name = "FormPersoneDettaglio";
            Text = "Dettagli persone";
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
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
        private BindingSource bindingSource2;
    }
}