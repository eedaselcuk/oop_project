using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace nyp2
{
    public partial class frmMasalar : Form
    {
         Veritabani db = new Veritabani();

        public frmMasalar()
        {
            InitializeComponent();
        }

        private void frmMasalar_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(db.baglantiString);
            SqlCommand komut = new SqlCommand("Select Durum,ID from masalar", baglanti);
            SqlDataReader verioku = null;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            verioku = komut.ExecuteReader();

            while (verioku.Read())
            {
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        if (item.Name =="btn_MASA"+ verioku["ID"].ToString() && verioku["Durum"].ToString() == "1")
                        {
                            item.BackColor = Color.Green ;

                        }

                        else if (item.Name =="btn_MASA"+ verioku["ID"].ToString() && verioku["Durum"].ToString() == "2")
                        {
                            
                            item.BackColor = Color.Navy;                     

                        }

                        else if (item.Name =="btn_MASA" + verioku["ID"].ToString() && verioku["Durum"].ToString() == "3")
                        {
                            item.BackColor = Color.Maroon; 

                        }
                        
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            this.Close();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btn_MASA1_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            frm.lblMNo.Text = btn_MASA1.Name.Substring(4, 5);
            // Veritabani._ButonDeger = btnm1.Text.Substring(uzunluk-6,6); // gelen uzunluk eksi 6 karakter
            Veritabani._ButonAd = btn_MASA1.Name;
            this.Close();
            frm.Show();
        }

        private void btn_MASA2_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            frm.lblMNo.Text = btn_MASA2.Name.Substring(4, 5);

            // Veritabani._ButonDeger = btnm2.Text.Substring(uzunluk - 6, 6); // gelen uzunluk eksi 6 karakter
            Veritabani._ButonAd = btn_MASA2.Name;
            this.Close();
            frm.Show();
        }

        private void btn_MASA3_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            frm.lblMNo.Text = btn_MASA3.Name.Substring(4, 5);

            // Veritabani._ButonDeger = btnm3.Text.Substring(uzunluk - 6, 6); // gelen uzunluk eksi 6 karakter
            Veritabani._ButonAd = btn_MASA3.Name;
            this.Close();
            frm.Show();
        }

        private void btn_MASA4_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            frm.lblMNo.Text = btn_MASA4.Name.Substring(4, 5);

            //Veritabani._ButonDeger = btnm4.Text.Substring(uzunluk - 6, 6); // gelen uzunluk eksi 6 karakter
            Veritabani._ButonAd = btn_MASA4.Name;
            this.Close();
            frm.Show();
        }
    }
}
