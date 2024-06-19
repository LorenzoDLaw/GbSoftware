namespace Manga.UI
{
    partial class FormPersone
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
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cognomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cittaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            annoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingSource2 = new BindingSource(components);
            btnAggiungi = new Button();
            btnRitorno = new Button();
            comboBox1 = new ComboBox();
            mangaBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mangaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, cognomeDataGridViewTextBoxColumn, cittaDataGridViewTextBoxColumn, annoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource2;
            dataGridView1.Location = new Point(12, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(511, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseDoubleClick += TabellaManga_CellMouseDoubleClick;
            dataGridView1.KeyDown += TabellaManga_KeyDown;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.FillWeight = 50F;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            cognomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cittaDataGridViewTextBoxColumn
            // 
            cittaDataGridViewTextBoxColumn.DataPropertyName = "Citta";
            cittaDataGridViewTextBoxColumn.HeaderText = "Citta";
            cittaDataGridViewTextBoxColumn.Name = "cittaDataGridViewTextBoxColumn";
            cittaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // annoDataGridViewTextBoxColumn
            // 
            annoDataGridViewTextBoxColumn.DataPropertyName = "Anno";
            annoDataGridViewTextBoxColumn.HeaderText = "Anno";
            annoDataGridViewTextBoxColumn.Name = "annoDataGridViewTextBoxColumn";
            annoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource2
            // 
            bindingSource2.DataSource = typeof(Persone);
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(12, 202);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(75, 23);
            btnAggiungi.TabIndex = 14;
            btnAggiungi.Text = "Aggiungi";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // btnRitorno
            // 
            btnRitorno.Location = new Point(142, 202);
            btnRitorno.Name = "btnRitorno";
            btnRitorno.Size = new Size(107, 23);
            btnRitorno.TabIndex = 15;
            btnRitorno.Text = "Passa ai manga";
            btnRitorno.UseVisualStyleBackColor = true;
            btnRitorno.Click += btnAnnulla_Click;
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("Text", mangaBindingSource, "Titolo", true));
            comboBox1.DataBindings.Add(new Binding("SelectedValue", mangaBindingSource, "Titolo", true));
            comboBox1.DataBindings.Add(new Binding("SelectedItem", mangaBindingSource, "Titolo", true));
            comboBox1.DataBindings.Add(new Binding("DataContext", mangaBindingSource, "Titolo", true));
            comboBox1.DataBindings.Add(new Binding("Tag", mangaBindingSource, "Titolo", true));
            comboBox1.DataSource = mangaBindingSource;
            comboBox1.DisplayMember = "Titolo";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(542, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 23);
            comboBox1.TabIndex = 16;
            comboBox1.DropDown += comboBox1_SelectedIndexChanged;
            // 
            // mangaBindingSource
            // 
            mangaBindingSource.DataSource = typeof(Manga);
            // 
            // FormPersone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 261);
            Controls.Add(comboBox1);
            Controls.Add(btnRitorno);
            Controls.Add(btnAggiungi);
            Controls.Add(dataGridView1);
            Name = "FormPersone";
            Text = "Tabella persone";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)mangaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAggiungi;
        private BindingSource bindingSource2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cittaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn annoDataGridViewTextBoxColumn;
        private Button btnRitorno;
        private ComboBox comboBox1;
        private BindingSource mangaBindingSource;
    }
}