using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TI1Stoku.AccessLayer;
using TI1Stoku.EntityLayer;

namespace TI1Stoku
{
    public partial class Regjistrimi_i_Klientave : Form
    {
        public Regjistrimi_i_Klientave()
        {
            InitializeComponent();
            simpleButton1.Click -= new EventHandler(SimpleButton2_Click);
            simpleButton1.Click += new EventHandler(SimpleButton1_Click);
        }

        public Regjistrimi_i_Klientave(int id,string emri,string mbiemri,string adresa,string nrbiz,string nrtel)
        {
            InitializeComponent();
            EmriTxt.Text = emri;
            MbiemriTxt.Text = mbiemri;
            AdresaTxt.Text = adresa;
            NumriBisnesorTxt.Text = nrbiz;
            NumriTelTxt.Text = nrtel;
            RegjistrimiKlientaveLbl.Text = "Update";
            simpleButton1.Text = "Update";
            simpleButton1.Click += new EventHandler(SimpleButton2_Click);
            simpleButton1.Click -= new EventHandler(SimpleButton1_Click);
            label1.Text = id.ToString();
        }

        private void EmriTxt_TextChanged(object sender, EventArgs e)
        {
            if(EmriTxt.Text=="Emri")
            {
                EmriTxt.Text = "";
                EmriTxt.ForeColor = Color.Black;
            }
        }

        private void EmriTxt_Leave(object sender, EventArgs e)
        {
            if (EmriTxt.Text == "")
            {
                EmriTxt.Text = "Emri";
                EmriTxt.ForeColor = Color.DarkGray;
            }
        }

        private void MbiemriTxt_Enter(object sender, EventArgs e)
        {
            if (MbiemriTxt.Text == "Mbiemri")
            {
                MbiemriTxt.Text = "";
                MbiemriTxt.ForeColor = Color.Black;
            }
        }

        private void MbiemriTxt_Leave(object sender, EventArgs e)
        {
            if (MbiemriTxt.Text == "")
            {
                MbiemriTxt.Text = "Mbiemri";
                MbiemriTxt.ForeColor = Color.DarkGray;
            }
        }

        private void MbiemriTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdresaTxt_Enter(object sender, EventArgs e)
        {
            if (AdresaTxt.Text == "Adresa")
            {
                AdresaTxt.Text = "";
                AdresaTxt.ForeColor = Color.Black;
            }
        }

        private void AdresaTxt_Leave(object sender, EventArgs e)
        {
            if (AdresaTxt.Text == "")
            {
                AdresaTxt.Text = "Adresa";
                AdresaTxt.ForeColor = Color.DarkGray;
            }
        }

        private void NumriTelTxt_Enter(object sender, EventArgs e)
        {
            if (NumriTelTxt.Text == "Numri Telefonit")
            {
                NumriTelTxt.Text = "";
                NumriTelTxt.ForeColor = Color.Black;
            }
        }

        private void NumriTelTxt_Leave(object sender, EventArgs e)
        {
            if (NumriTelTxt.Text == "")
            {
                NumriTelTxt.Text = "Numri Telefonit";
                NumriTelTxt.ForeColor = Color.DarkGray;
            }
        }

        private void NumriBisnesorTxt_Enter(object sender, EventArgs e)
        {
            if (NumriBisnesorTxt.Text == "Numri Biznesor")
            {
                NumriBisnesorTxt.Text = "";
                NumriBisnesorTxt.ForeColor = Color.Black;
            }
        }

        private void NumriBisnesorTxt_Leave(object sender, EventArgs e)
        {
            if (NumriBisnesorTxt.Text == "")
            {
                NumriBisnesorTxt.Text = "Numri Biznesor";
                NumriBisnesorTxt.ForeColor = Color.DarkGray;
            }
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            DAKonsumatori.Insert(EmriTxt.Text, MbiemriTxt.Text, AdresaTxt.Text, NumriBisnesorTxt.Text, NumriTelTxt.Text);
        }
        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            DAKonsumatori.Update(Int32.Parse(label1.Text), EmriTxt.Text, MbiemriTxt.Text, AdresaTxt.Text, NumriBisnesorTxt.Text, NumriTelTxt.Text);
        }
    }
}
