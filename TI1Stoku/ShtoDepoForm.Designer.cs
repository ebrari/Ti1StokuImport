namespace TI1Stoku
{
    partial class ShtoDepoForm
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
            this.EmriTxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ShtoBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shto Depo";
            // 
            // EmriTxt
            // 
            this.EmriTxt.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.EmriTxt.Location = new System.Drawing.Point(75, 176);
            this.EmriTxt.Multiline = true;
            this.EmriTxt.Name = "EmriTxt";
            this.EmriTxt.Size = new System.Drawing.Size(265, 28);
            this.EmriTxt.TabIndex = 2;
            this.EmriTxt.Text = "Rruga";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Location = new System.Drawing.Point(75, 123);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 28);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Qyteti";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.Location = new System.Drawing.Point(75, 229);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 28);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Lagja";
            // 
            // ShtoBtn
            // 
            this.ShtoBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShtoBtn.Appearance.Options.UseFont = true;
            this.ShtoBtn.Location = new System.Drawing.Point(137, 288);
            this.ShtoBtn.Name = "ShtoBtn";
            this.ShtoBtn.Size = new System.Drawing.Size(147, 33);
            this.ShtoBtn.TabIndex = 5;
            this.ShtoBtn.Text = "Shto ";
            // 
            // ShtoDepoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.ShtoBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EmriTxt);
            this.Controls.Add(this.label1);
            this.Name = "ShtoDepoForm";
            this.Text = "ShtoDepoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmriTxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private DevExpress.XtraEditors.SimpleButton ShtoBtn;
    }
}