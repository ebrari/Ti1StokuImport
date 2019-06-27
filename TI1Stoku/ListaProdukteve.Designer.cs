namespace TI1Stoku
{
    partial class ListaProdukteve
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.produktiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barkodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSkadimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmimiShitjesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmimiBlerjesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pershkrimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodhuesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnitoriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produktiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkodiDataGridViewTextBoxColumn,
            this.dataSkadimitDataGridViewTextBoxColumn,
            this.cmimiShitjesDataGridViewTextBoxColumn,
            this.cmimiBlerjesDataGridViewTextBoxColumn,
            this.pershkrimiDataGridViewTextBoxColumn,
            this.prodhuesiDataGridViewTextBoxColumn,
            this.emriDataGridViewTextBoxColumn,
            this.furnitoriIDDataGridViewTextBoxColumn,
            this.kategoriaIDDataGridViewTextBoxColumn,
            this.produktiIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produktiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // produktiBindingSource
            // 
            this.produktiBindingSource.DataSource = typeof(TI1Stoku.EntityLayer.Produkti);
            // 
            // barkodiDataGridViewTextBoxColumn
            // 
            this.barkodiDataGridViewTextBoxColumn.DataPropertyName = "Barkodi";
            this.barkodiDataGridViewTextBoxColumn.HeaderText = "Barkodi";
            this.barkodiDataGridViewTextBoxColumn.Name = "barkodiDataGridViewTextBoxColumn";
            // 
            // dataSkadimitDataGridViewTextBoxColumn
            // 
            this.dataSkadimitDataGridViewTextBoxColumn.DataPropertyName = "DataSkadimit";
            this.dataSkadimitDataGridViewTextBoxColumn.HeaderText = "DataSkadimit";
            this.dataSkadimitDataGridViewTextBoxColumn.Name = "dataSkadimitDataGridViewTextBoxColumn";
            // 
            // cmimiShitjesDataGridViewTextBoxColumn
            // 
            this.cmimiShitjesDataGridViewTextBoxColumn.DataPropertyName = "CmimiShitjes";
            this.cmimiShitjesDataGridViewTextBoxColumn.HeaderText = "CmimiShitjes";
            this.cmimiShitjesDataGridViewTextBoxColumn.Name = "cmimiShitjesDataGridViewTextBoxColumn";
            // 
            // cmimiBlerjesDataGridViewTextBoxColumn
            // 
            this.cmimiBlerjesDataGridViewTextBoxColumn.DataPropertyName = "CmimiBlerjes";
            this.cmimiBlerjesDataGridViewTextBoxColumn.HeaderText = "CmimiBlerjes";
            this.cmimiBlerjesDataGridViewTextBoxColumn.Name = "cmimiBlerjesDataGridViewTextBoxColumn";
            // 
            // pershkrimiDataGridViewTextBoxColumn
            // 
            this.pershkrimiDataGridViewTextBoxColumn.DataPropertyName = "Pershkrimi";
            this.pershkrimiDataGridViewTextBoxColumn.HeaderText = "Pershkrimi";
            this.pershkrimiDataGridViewTextBoxColumn.Name = "pershkrimiDataGridViewTextBoxColumn";
            // 
            // prodhuesiDataGridViewTextBoxColumn
            // 
            this.prodhuesiDataGridViewTextBoxColumn.DataPropertyName = "Prodhuesi";
            this.prodhuesiDataGridViewTextBoxColumn.HeaderText = "Prodhuesi";
            this.prodhuesiDataGridViewTextBoxColumn.Name = "prodhuesiDataGridViewTextBoxColumn";
            // 
            // emriDataGridViewTextBoxColumn
            // 
            this.emriDataGridViewTextBoxColumn.DataPropertyName = "Emri";
            this.emriDataGridViewTextBoxColumn.HeaderText = "Emri";
            this.emriDataGridViewTextBoxColumn.Name = "emriDataGridViewTextBoxColumn";
            // 
            // furnitoriIDDataGridViewTextBoxColumn
            // 
            this.furnitoriIDDataGridViewTextBoxColumn.DataPropertyName = "Furnitori_ID";
            this.furnitoriIDDataGridViewTextBoxColumn.HeaderText = "Furnitori_ID";
            this.furnitoriIDDataGridViewTextBoxColumn.Name = "furnitoriIDDataGridViewTextBoxColumn";
            // 
            // kategoriaIDDataGridViewTextBoxColumn
            // 
            this.kategoriaIDDataGridViewTextBoxColumn.DataPropertyName = "Kategoria_ID";
            this.kategoriaIDDataGridViewTextBoxColumn.HeaderText = "Kategoria_ID";
            this.kategoriaIDDataGridViewTextBoxColumn.Name = "kategoriaIDDataGridViewTextBoxColumn";
            // 
            // produktiIDDataGridViewTextBoxColumn
            // 
            this.produktiIDDataGridViewTextBoxColumn.DataPropertyName = "Produkti_ID";
            this.produktiIDDataGridViewTextBoxColumn.HeaderText = "Produkti_ID";
            this.produktiIDDataGridViewTextBoxColumn.Name = "produktiIDDataGridViewTextBoxColumn";
            // 
            // ListaProdukteve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListaProdukteve";
            this.Text = "ListaProdukteve";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSkadimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmimiShitjesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmimiBlerjesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pershkrimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodhuesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnitoriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produktiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource produktiBindingSource;
    }
}