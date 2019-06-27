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
    public partial class ListaKlienti : Form
    {
        public ListaKlienti()
        {
            InitializeComponent();
            List<Konsumatori> k1 = DAKonsumatori.GetAll();
            
            dataGridView1.DataSource = k1;
        }
        int id = 0;
        string emri;
        string mbiemri;
        string adresa;
        string nrbiz;
        string nrtel;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            emri =    dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            mbiemri = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            adresa =  dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            nrbiz =   dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            nrtel =   dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void Delete(object sender, EventArgs e)
        {
            if (id!=0)
            {
                DAKonsumatori.DeleteById(id);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Regjistrimi_i_Klientave frm = new Regjistrimi_i_Klientave(id,emri,mbiemri,adresa,nrbiz,nrtel);
            frm.MdiParent = this.MdiParent;
            ShowForm(frm);
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
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }
    }
}
