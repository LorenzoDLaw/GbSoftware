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
            btnMenoCostoso = new Button();
            btnPiuCostoso = new Button();
            btnAggiungi = new Button();
            dataGridView = new DataGridView();
            binSourceItem = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titoloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prezzoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroPagineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)binSourceItem).BeginInit();
            SuspendLayout();
            // 
            // btnMenoCostoso
            // 
            btnMenoCostoso.Location = new Point(205, 211);
            btnMenoCostoso.Name = "btnMenoCostoso";
            btnMenoCostoso.Size = new Size(75, 23);
            btnMenoCostoso.TabIndex = 13;
            btnMenoCostoso.Text = "- costoso";
            btnMenoCostoso.UseVisualStyleBackColor = true;
            btnMenoCostoso.Click += btnMenoCostoso_Click;
            // 
            // btnPiuCostoso
            // 
            btnPiuCostoso.Location = new Point(110, 211);
            btnPiuCostoso.Name = "btnPiuCostoso";
            btnPiuCostoso.Size = new Size(75, 23);
            btnPiuCostoso.TabIndex = 12;
            btnPiuCostoso.Text = "+ costoso";
            btnPiuCostoso.UseVisualStyleBackColor = true;
            btnPiuCostoso.Click += btnPiuCostoso_Click;
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
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titoloDataGridViewTextBoxColumn, prezzoDataGridViewTextBoxColumn, numeroPagineDataGridViewTextBoxColumn });
            dataGridView.DataSource = binSourceItem;
            dataGridView.Location = new Point(8, 36);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(443, 150);
            dataGridView.TabIndex = 14;
            // 
            // binSourceItem
            // 
            binSourceItem.DataSource = typeof(ModelloManga);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(dataGridView);
            Controls.Add(btnMenoCostoso);
            Controls.Add(btnPiuCostoso);
            Controls.Add(btnAggiungi);
            Name = "Form1";
            Text = "ListaManga";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)binSourceItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenoCostoso;
        private Button btnPiuCostoso;
        private Button btnAggiungi;
        private DataGridView dataGridView;
        private BindingSource binSourceItem;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titoloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prezzoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroPagineDataGridViewTextBoxColumn;
    }
}
