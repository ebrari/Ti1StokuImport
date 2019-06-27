namespace TI1Stoku
{
    partial class ListaPorosiveForm
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
            this.porosiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.puntoriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPorosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porosiaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konsumatoriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porosiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.puntoriIDDataGridViewTextBoxColumn,
            this.dataPorosisDataGridViewTextBoxColumn,
            this.porosiaIDDataGridViewTextBoxColumn,
            this.konsumatoriIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.porosiaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // porosiaBindingSource
            // 
            this.porosiaBindingSource.DataSource = typeof(TI1Stoku.EntityLayer.Porosia);
            // 
            // puntoriIDDataGridViewTextBoxColumn
            // 
            this.puntoriIDDataGridViewTextBoxColumn.DataPropertyName = "Puntori_ID";
            this.puntoriIDDataGridViewTextBoxColumn.HeaderText = "Puntori_ID";
            this.puntoriIDDataGridViewTextBoxColumn.Name = "puntoriIDDataGridViewTextBoxColumn";
            // 
            // dataPorosisDataGridViewTextBoxColumn
            // 
            this.dataPorosisDataGridViewTextBoxColumn.DataPropertyName = "DataPorosis";
            this.dataPorosisDataGridViewTextBoxColumn.HeaderText = "DataPorosis";
            this.dataPorosisDataGridViewTextBoxColumn.Name = "dataPorosisDataGridViewTextBoxColumn";
            // 
            // porosiaIDDataGridViewTextBoxColumn
            // 
            this.porosiaIDDataGridViewTextBoxColumn.DataPropertyName = "Porosia_ID";
            this.porosiaIDDataGridViewTextBoxColumn.HeaderText = "Porosia_ID";
            this.porosiaIDDataGridViewTextBoxColumn.Name = "porosiaIDDataGridViewTextBoxColumn";
            // 
            // konsumatoriIDDataGridViewTextBoxColumn
            // 
            this.konsumatoriIDDataGridViewTextBoxColumn.DataPropertyName = "Konsumatori_ID";
            this.konsumatoriIDDataGridViewTextBoxColumn.HeaderText = "Konsumatori_ID";
            this.konsumatoriIDDataGridViewTextBoxColumn.Name = "konsumatoriIDDataGridViewTextBoxColumn";
            // 
            // ListaPorosiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(563, 436);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListaPorosiveForm";
            this.Text = "ListaPorosiveForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porosiaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntoriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPorosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porosiaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konsumatoriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource porosiaBindingSource;
    }
}