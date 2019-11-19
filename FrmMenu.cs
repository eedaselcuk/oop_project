using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nyp2
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnMasa_Click(object sender, EventArgs e)
        {
            frmMasalar frm = new frmMasalar();
            this.Close();
            frm.Show();
        }

    
       

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            frmMusteriler frm = new frmMusteriler();
            this.Close();
            frm.Show();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            frmKasa frm = new frmKasa();
            this.Close();
            frm.Show();
        }

      

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMutfak_Click_1(object sender, EventArgs e)
        {
            frmMutfak frm = new frmMutfak();
            this.Close();
            frm.Show();
        }

        private void btnRezerve_Click(object sender, EventArgs e)
        {
            frmRezerve frm = new frmRezerve();
            this.Close();
            frm.Show();
        }
    }
}
