namespace TI1Stoku
{
    partial class ShtoKompaniForm
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.NumriBisnesorTxt = new System.Windows.Forms.TextBox();
            this.NumriTelTxt = new System.Windows.Forms.TextBox();
            this.AdresaTxt = new System.Windows.Forms.TextBox();
            this.EmriTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shto Kompanin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.LightCoral;
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(171, 366);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(181, 37);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Prano";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // NumriBisnesorTxt
            // 
            this.NumriBisnesorTxt.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NumriBisnesorTxt.Location = new System.Drawing.Point(131, 255);
            this.NumriBisnesorTxt.Multiline = true;
            this.NumriBisnesorTxt.Name = "NumriBisnesorTxt";
            this.NumriBisnesorTxt.Size = new System.Drawing.Size(265, 28);
            this.NumriBisnesorTxt.TabIndex = 11;
            this.NumriBisnesorTxt.Text = "Numri Biznesor";
            this.NumriBisnesorTxt.TextChanged += new System.EventHandler(this.NumriBisnesorTxt_TextChanged);
            // 
            // NumriTelTxt
            // 
            this.NumriTelTxt.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NumriTelTxt.Location = new System.Drawing.Point(131, 197);
            this.NumriTelTxt.Multiline = true;
            this.NumriTelTxt.Name = "NumriTelTxt";
            this.NumriTelTxt.Size = new System.Drawing.Size(265, 28);
            this.NumriTelTxt.TabIndex = 10;
            this.NumriTelTxt.Text = "Numri Telefonit";
            this.NumriTelTxt.TextChanged += new System.EventHandler(this.NumriTelTxt_TextChanged);
            // 
            // AdresaTxt
            // 
            this.AdresaTxt.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.AdresaTxt.Location = new System.Drawing.Point(131, 141);
            this.AdresaTxt.Multiline = true;
            this.AdresaTxt.Name = "AdresaTxt";
            this.AdresaTxt.Size = new System.Drawing.Size(265, 28);
            this.AdresaTxt.TabIndex = 9;
            this.AdresaTxt.Text = "Adresa";
            this.AdresaTxt.TextChanged += new System.EventHandler(this.AdresaTxt_TextChanged);
            // 
            // EmriTxt
            // 
            this.EmriTxt.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.EmriTxt.Location = new System.Drawing.Point(131, 85);
            this.EmriTxt.Multiline = true;
            this.EmriTxt.Name = "EmriTxt";
            this.EmriTxt.Size = new System.Drawing.Size(265, 28);
            this.EmriTxt.TabIndex = 7;
            this.EmriTxt.Text = "Emri";
            this.EmriTxt.TextChanged += new System.EventHandler(this.EmriTxt_TextChanged);
            // 
            // ShtoKompaniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.NumriBisnesorTxt);
            this.Controls.Add(this.NumriTelTxt);
            this.Controls.Add(this.AdresaTxt);
            this.Controls.Add(this.EmriTxt);
            this.Controls.Add(this.label1);
            this.Name = "ShtoKompaniForm";
            this.Text = "ShtoKompaniForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox NumriBisnesorTxt;
        private System.Windows.Forms.TextBox NumriTelTxt;
        private System.Windows.Forms.TextBox AdresaTxt;
        private System.Windows.Forms.TextBox EmriTxt;
    }
}