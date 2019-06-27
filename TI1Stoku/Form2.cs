using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
namespace TI1Stoku
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void propertyGridControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void ShowForm(Form frm)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == frm.Text)
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                //Form2 f2 = new Form2();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ListaDepoveForm frm = new ListaDepoveForm();
            frm.MdiParent = this;
            ShowForm(frm);
        }

        private void navBarItem2_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ListaPorosiveForm frm = new ListaPorosiveForm();
            frm.MdiParent = this;
            ShowForm(frm);
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ListaKlienti frm = new ListaKlienti();
            frm.MdiParent = this;
            ShowForm(frm);
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ListaFurnizimeveForm frm = new ListaFurnizimeveForm();
            frm.MdiParent = this;
            ShowForm(frm);
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Regjistrimi_i_Klientave frm = new Regjistrimi_i_Klientave();
            frm.MdiParent = this;
            ShowForm(frm);
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ListaKompanive frm = new ListaKompanive();
            frm.MdiParent = this;
            ShowForm(frm);
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShtoDepoForm frm = new ShtoDepoForm();
            frm.MdiParent = this;
            ShowForm(frm);
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShtoPorosinForm frm = new ShtoPorosinForm();
            frm.MdiParent = this;
            ShowForm(frm);
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShtoFurnizimin frm = new ShtoFurnizimin();
            frm.MdiParent = this;
            ShowForm(frm);
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Regjistrimi_i_Klientave frm = new Regjistrimi_i_Klientave();
            frm.MdiParent = this;
            ShowForm(frm);
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShtoKompaniForm frm = new ShtoKompaniForm();
            frm.MdiParent = this;
            ShowForm(frm);
        }

        private void navBarItem4_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ListaProdukteve frm = new ListaProdukteve();
            frm.MdiParent = this;
            ShowForm(frm);
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShtoProdukte frm = new ShtoProdukte();
            frm.MdiParent = this;
            ShowForm(frm);
        }
    }
}
