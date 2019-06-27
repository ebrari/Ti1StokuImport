namespace TI1Stoku
{
    partial class ListaKlienti
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
            this.konsumatoriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbiemriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numriBiznesorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numriTelefonitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konsumatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konsumatoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.konsumatoriIDDataGridViewTextBoxColumn,
            this.emriDataGridViewTextBoxColumn,
            this.mbiemriDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.numriBiznesorDataGridViewTextBoxColumn,
            this.numriTelefonitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.konsumatoriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 390);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            // 
            // konsumatoriIDDataGridViewTextBoxColumn
            // 
            this.konsumatoriIDDataGridViewTextBoxColumn.DataPropertyName = "Konsumatori_ID";
            this.konsumatoriIDDataGridViewTextBoxColumn.HeaderText = "Konsumatori_ID";
            this.konsumatoriIDDataGridViewTextBoxColumn.Name = "konsumatoriIDDataGridViewTextBoxColumn";
            // 
            // emriDataGridViewTextBoxColumn
            // 
            this.emriDataGridViewTextBoxColumn.DataPropertyName = "Emri";
            this.emriDataGridViewTextBoxColumn.HeaderText = "Emri";
            this.emriDataGridViewTextBoxColumn.Name = "emriDataGridViewTextBoxColumn";
            // 
            // mbiemriDataGridViewTextBoxColumn
            // 
            this.mbiemriDataGridViewTextBoxColumn.DataPropertyName = "Mbiemri";
            this.mbiemriDataGridViewTextBoxColumn.HeaderText = "Mbiemri";
            this.mbiemriDataGridViewTextBoxColumn.Name = "mbiemriDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // numriBiznesorDataGridViewTextBoxColumn
            // 
            this.numriBiznesorDataGridViewTextBoxColumn.DataPropertyName = "NumriBiznesor";
            this.numriBiznesorDataGridViewTextBoxColumn.HeaderText = "NumriBiznesor";
            this.numriBiznesorDataGridViewTextBoxColumn.Name = "numriBiznesorDataGridViewTextBoxColumn";
            // 
            // numriTelefonitDataGridViewTextBoxColumn
            // 
            this.numriTelefonitDataGridViewTextBoxColumn.DataPropertyName = "NumriTelefonit";
            this.numriTelefonitDataGridViewTextBoxColumn.HeaderText = "NumriTelefonit";
            this.numriTelefonitDataGridViewTextBoxColumn.Name = "numriTelefonitDataGridViewTextBoxColumn";
            // 
            // konsumatoriBindingSource
            // 
            this.konsumatoriBindingSource.DataSource = typeof(TI1Stoku.EntityLayer.Konsumatori);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Delete);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ListaKlienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListaKlienti";
            this.Text = "ListaKlienti";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konsumatoriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource konsumatoriBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn konsumatoriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbiemriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numriBiznesorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numriTelefonitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}