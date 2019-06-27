namespace TI1Stoku
{
    partial class ShtoFurnizimin
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
            this.label1 = new System.Windows.Forms.Label();
            this.DataFurnizimi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataPranimit = new System.Windows.Forms.DateTimePicker();
            this.ShtoFurnizimBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shto Furnizimi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DataFurnizimi
            // 
            this.DataFurnizimi.Location = new System.Drawing.Point(111, 112);
            this.DataFurnizimi.Name = "DataFurnizimi";
            this.DataFurnizimi.Size = new System.Drawing.Size(237, 20);
            this.DataFurnizimi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "DataPranimit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "DataPorosis";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DataPranimit
            // 
            this.DataPranimit.Location = new System.Drawing.Point(111, 163);
            this.DataPranimit.Name = "DataPranimit";
            this.DataPranimit.Size = new System.Drawing.Size(237, 20);
            this.DataPranimit.TabIndex = 9;
            // 
            // ShtoFurnizimBtn
            // 
            this.ShtoFurnizimBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShtoFurnizimBtn.Appearance.Options.UseFont = true;
            this.ShtoFurnizimBtn.Location = new System.Drawing.Point(160, 224);
            this.ShtoFurnizimBtn.Name = "ShtoFurnizimBtn";
            this.ShtoFurnizimBtn.Size = new System.Drawing.Size(124, 29);
            this.ShtoFurnizimBtn.TabIndex = 10;
            this.ShtoFurnizimBtn.Text = "Shto";
            // 
            // ShtoFurnizimin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 350);
            this.Controls.Add(this.ShtoFurnizimBtn);
            this.Controls.Add(this.DataPranimit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataFurnizimi);
            this.Controls.Add(this.label1);
            this.Name = "ShtoFurnizimin";
            this.Text = "ShtoFurnizimin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DataFurnizimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DataPranimit;
        private DevExpress.XtraEditors.SimpleButton ShtoFurnizimBtn;
    }
}