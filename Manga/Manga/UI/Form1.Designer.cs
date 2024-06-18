namespace Manga
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
            components = new System.ComponentModel.Container();
            btnAggiungi = new Button();
            bindingSource1 = new BindingSource(components);
            TabellaManga = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titoloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prezzoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroPagineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btnPiuCostoso = new Button();
            btnMenoCostoso = new Button();
            btnPassToPersona = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TabellaManga).BeginInit();
            SuspendLayout();
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(12, 211);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(75, 23);
            btnAggiungi.TabIndex = 11;
            btnAggiungi.Text = "Aggiungi";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Manga);
            // 
            // TabellaManga
            // 
            TabellaManga.AllowUserToAddRows = false;
            TabellaManga.AllowUserToDeleteRows = false;
            TabellaManga.AutoGenerateColumns = false;
            TabellaManga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabellaManga.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titoloDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, prezzoDataGridViewTextBoxColumn, numeroPagineDataGridViewTextBoxColumn });
            TabellaManga.DataSource = bindingSource1;
            TabellaManga.GridColor = SystemColors.MenuHighlight;
            TabellaManga.Location = new Point(1, 34);
            TabellaManga.Name = "TabellaManga";
            TabellaManga.ReadOnly = true;
            TabellaManga.Size = new Size(543, 150);
            TabellaManga.TabIndex = 14;
            TabellaManga.CellMouseDoubleClick += TabellaManga_CellMouseDoubleClick;
            TabellaManga.KeyDown += TabellaManga_KeyDown;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titoloDataGridViewTextBoxColumn
            // 
            titoloDataGridViewTextBoxColumn.DataPropertyName = "Titolo";
            titoloDataGridViewTextBoxColumn.HeaderText = "Titolo";
            titoloDataGridViewTextBoxColumn.Name = "titoloDataGridViewTextBoxColumn";
            titoloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezzoDataGridViewTextBoxColumn
            // 
            prezzoDataGridViewTextBoxColumn.DataPropertyName = "Prezzo";
            prezzoDataGridViewTextBoxColumn.HeaderText = "Prezzo";
            prezzoDataGridViewTextBoxColumn.Name = "prezzoDataGridViewTextBoxColumn";
            prezzoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroPagineDataGridViewTextBoxColumn
            // 
            numeroPagineDataGridViewTextBoxColumn.DataPropertyName = "NumeroPagine";
            numeroPagineDataGridViewTextBoxColumn.HeaderText = "NumeroPagine";
            numeroPagineDataGridViewTextBoxColumn.Name = "numeroPagineDataGridViewTextBoxColumn";
            numeroPagineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnPiuCostoso
            // 
            btnPiuCostoso.Location = new Point(114, 211);
            btnPiuCostoso.Name = "btnPiuCostoso";
            btnPiuCostoso.Size = new Size(75, 23);
            btnPiuCostoso.TabIndex = 15;
            btnPiuCostoso.Text = "+ Costoso";
            btnPiuCostoso.UseVisualStyleBackColor = true;
            btnPiuCostoso.Click += btnPiuCostoso_Click;
            // 
            // btnMenoCostoso
            // 
            btnMenoCostoso.Location = new Point(221, 211);
            btnMenoCostoso.Name = "btnMenoCostoso";
            btnMenoCostoso.Size = new Size(75, 23);
            btnMenoCostoso.TabIndex = 16;
            btnMenoCostoso.Text = "- Costoso";
            btnMenoCostoso.UseVisualStyleBackColor = true;
            btnMenoCostoso.Click += btnMenoCostoso_Click;
            // 
            // btnPassToPersona
            // 
            btnPassToPersona.Location = new Point(394, 211);
            btnPassToPersona.Name = "btnPassToPersona";
            btnPassToPersona.Size = new Size(125, 23);
            btnPassToPersona.TabIndex = 17;
            btnPassToPersona.Text = "Passa alle persone";
            btnPassToPersona.UseVisualStyleBackColor = true;
            btnPassToPersona.Click += btnPassToPersona_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 261);
            Controls.Add(btnPassToPersona);
            Controls.Add(btnMenoCostoso);
            Controls.Add(btnPiuCostoso);
            Controls.Add(TabellaManga);
            Controls.Add(btnAggiungi);
            Name = "Form1";
            Text = "ListaManga";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TabellaManga).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAggiungi;
        private BindingSource bindingSource1;
        private DataGridView TabellaManga;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titoloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prezzoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroPagineDataGridViewTextBoxColumn;
        private Button btnPiuCostoso;
        private Button btnMenoCostoso;
        private Button btnPassToPersona;
    }
}
