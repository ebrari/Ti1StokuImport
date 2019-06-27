namespace TI1Stoku
{
    partial class Regjistrimi_i_Klientave
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
            this.RegjistrimiKlientaveLbl = new System.Windows.Forms.Label();
            this.EmriTxt = new System.Windows.Forms.TextBox();
            this.MbiemriTxt = new System.Windows.Forms.TextBox();
            this.AdresaTxt = new System.Windows.Forms.TextBox();
            this.NumriTelTxt = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.NumriBisnesorTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegjistrimiKlientaveLbl
            // 
            this.RegjistrimiKlientaveLbl.AutoSize = true;
            this.RegjistrimiKlientaveLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegjistrimiKlientaveLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegjistrimiKlientaveLbl.Location = new System.Drawing.Point(67, 32);
            this.RegjistrimiKlientaveLbl.Name = "RegjistrimiKlientaveLbl";
            this.RegjistrimiKlientaveLbl.Size = new System.Drawing.Size(290, 33);
            this.RegjistrimiKlientaveLbl.TabIndex = 0;
            this.RegjistrimiKlientaveLbl.Text = "Regjistrimi i Klientave";
            // 
            // EmriTxt
            // 
            this.EmriTxt.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.EmriTxt.Location = new System.Drawing.Point(73, 105);
            this.EmriTxt.Multiline = true;
            this.EmriTxt.Name = "EmriTxt";
            this.EmriTxt.Size = new System.Drawing.Size(265, 28);
            this.EmriTxt.TabIndex = 1;
            this.EmriTxt.Text = "Emri";
            this.EmriTxt.Enter += new System.EventHandler(this.EmriTxt_TextChanged);
            this.EmriTxt.Leave += new System.EventHandler(this.EmriTxt_Leave);
            // 
            // MbiemriTxt
            // 
            this.MbiemriTxt.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.MbiemriTxt.Location = new System.Drawing.Point(73, 159);
            this.MbiemriTxt.Multiline = true;
            this.MbiemriTxt.Name = "MbiemriTxt";
            this.MbiemriTxt.Size = new System.Drawing.Size(265, 28);
            this.MbiemriTxt.TabIndex = 2;
            this.MbiemriTxt.Text = "Mbiemri";
            this.MbiemriTxt.TextChanged += new System.EventHandler(this.MbiemriTxt_TextChanged);
            this.MbiemriTxt.Enter += new System.EventHandler(this.MbiemriTxt_Enter);
            this.MbiemriTxt.Leave += new System.EventHandler(this.MbiemriTxt_Leave);
            // 
            // AdresaTxt
            // 
            this.AdresaTxt.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.AdresaTxt.Location = new System.Drawing.Point(73, 218);
            this.AdresaTxt.Multiline = true;
            this.AdresaTxt.Name = "AdresaTxt";
            this.AdresaTxt.Size = new System.Drawing.Size(265, 28);
            this.AdresaTxt.TabIndex = 3;
            this.AdresaTxt.Text = "Adresa";
            this.AdresaTxt.Enter += new System.EventHandler(this.AdresaTxt_Enter);
            this.AdresaTxt.Leave += new System.EventHandler(this.AdresaTxt_Leave);
            // 
            // NumriTelTxt
            // 
            this.NumriTelTxt.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NumriTelTxt.Location = new System.Drawing.Point(73, 274);
            this.NumriTelTxt.Multiline = true;
            this.NumriTelTxt.Name = "NumriTelTxt";
            this.NumriTelTxt.Size = new System.Drawing.Size(265, 28);
            this.NumriTelTxt.TabIndex = 4;
            this.NumriTelTxt.Text = "Numri Telefonit";
            this.NumriTelTxt.Enter += new System.EventHandler(this.NumriTelTxt_Enter);
            this.NumriTelTxt.Leave += new System.EventHandler(this.NumriTelTxt_Leave);
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
            this.simpleButton1.Location = new System.Drawing.Point(113, 386);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(181, 37);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Prano";
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // NumriBisnesorTxt
            // 
            this.NumriBisnesorTxt.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NumriBisnesorTxt.Location = new System.Drawing.Point(73, 332);
            this.NumriBisnesorTxt.Multiline = true;
            this.NumriBisnesorTxt.Name = "NumriBisnesorTxt";
            this.NumriBisnesorTxt.Size = new System.Drawing.Size(265, 28);
            this.NumriBisnesorTxt.TabIndex = 5;
            this.NumriBisnesorTxt.Text = "Numri Biznesor";
            this.NumriBisnesorTxt.Enter += new System.EventHandler(this.NumriBisnesorTxt_Enter);
            this.NumriBisnesorTxt.Leave += new System.EventHandler(this.NumriBisnesorTxt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Regjistrimi_i_Klientave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(427, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.NumriBisnesorTxt);
            this.Controls.Add(this.NumriTelTxt);
            this.Controls.Add(this.AdresaTxt);
            this.Controls.Add(this.MbiemriTxt);
            this.Controls.Add(this.EmriTxt);
            this.Controls.Add(this.RegjistrimiKlientaveLbl);
            this.Name = "Regjistrimi_i_Klientave";
            this.Text = "Regjistrimi_i_Klientave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegjistrimiKlientaveLbl;
        private System.Windows.Forms.TextBox EmriTxt;
        private System.Windows.Forms.TextBox MbiemriTxt;
        private System.Windows.Forms.TextBox AdresaTxt;
        private System.Windows.Forms.TextBox NumriTelTxt;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox NumriBisnesorTxt;
        private System.Windows.Forms.Label label1;
    }
}