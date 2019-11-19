using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace nyp2
{
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }

        private void btnana_Click(object sender, EventArgs e)
        {
            UrunCekme(2);
        }

        //hesap makinesi  metodu form loaddan önce yazdık 
        void islem(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btn_MASA1":
                    tbAdet.Text += (1).ToString();
                    break;
                case "btn_MASA2":
                    tbAdet.Text += (2).ToString();
                    break;
                case "btn_MASA3":
                    tbAdet.Text += (3).ToString();
                    break;
                case "btn_MASA4":
                    tbAdet.Text += (4).ToString();
                    break;

                default:
                    

                    break;

            }
        }

        private void frmSiparis_Load(object sender, EventArgs e)
        {
           
            masalarClss ms = new masalarClss();
            int masaID = ms.MasaNumarasiAl(Veritabani._ButonAd);
            if (ms.MasaDurumAl(masaID, 2) == true || ms.MasaDurumAl(masaID, 4) == true)
            {
                AdisyonClss Adisyon = new AdisyonClss();
                int _adisyonID = Adisyon.AdisyonAl(masaID);
                SiparisClss orders = new SiparisClss();
                orders.SiparisGetir(lvSiparis, _adisyonID);


            }

            btn1.Click += new EventHandler(islem);
            btn2.Click += new EventHandler(islem);
            btn3.Click += new EventHandler(islem);
            btn4.Click += new EventHandler(islem);
            btn5.Click += new EventHandler(islem);
            btn6.Click += new EventHandler(islem);
            btn7.Click += new EventHandler(islem);
            btn8.Click += new EventHandler(islem);
            btn9.Click += new EventHandler(islem);
            btn0.Click += new EventHandler(islem);

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

        private void tbAdet_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btncorba_Click(object sender, EventArgs e)
        {
            UrunCekme(1);
        }

        private void btnmakarna_Click(object sender, EventArgs e)
        { 
            UrunCekme(3);
        }
        string fiyat;
        public void UrunCekme(int kategoriid)
        {
            listView1.Items.Clear();
            Veritabani db = new Veritabani();
            SqlConnection baglanti = new SqlConnection(db.baglantiString);
            SqlCommand komut = new SqlCommand("Select UrunAd,FIYAT from Urunler where KategoriID="+kategoriid.ToString(), baglanti);
            SqlDataReader verioku = null;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            verioku = komut.ExecuteReader();
            int sayac = 0;
            while (verioku.Read())
            {
                listView1.Items.Add(verioku["UrunAd"].ToString());
                listView1.Items[sayac].SubItems.Add(verioku["FIYAT"].ToString());
                fiyat = verioku["FIYAT"].ToString();
                sayac++;
            }
            baglanti.Close();
           
        }

        private void btnburger_Click(object sender, EventArgs e)
        {
            UrunCekme(5);
        }

        private void btnsoguk_Click(object sender, EventArgs e)
        {
            UrunCekme(4);
        }

        private void btnkahvalti_Click(object sender, EventArgs e)
        {
            UrunCekme(6);
        }

        private void btnpizza_Click(object sender, EventArgs e)
        {
            UrunCekme(7);

        }

        private void btntatli_Click(object sender, EventArgs e)
        {
            UrunCekme(8);
        }

        private void btnsicak_Click(object sender, EventArgs e)
        {
            UrunCekme(9);
        }

        private void btnsalata_Click(object sender, EventArgs e)
        {
            UrunCekme(10);
        }
        int adet = 0;
        private void btn1_Click(object sender, EventArgs e)
        {
             adet += 1;
            tbAdet.Text += adet.ToString();
           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            adet += 2;
            tbAdet.Text += adet.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            adet += 3;
            tbAdet.Text += adet.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            adet += 4;
            tbAdet.Text += adet.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            adet += 5;
            tbAdet.Text += adet.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            adet += 6;
            tbAdet.Text += adet.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            adet += 7;
            tbAdet.Text += adet.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            adet += 8;
            tbAdet.Text += adet.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            adet += 9;
            tbAdet.Text += adet.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            adet = 0;
            tbAdet.Text = adet.ToString();
        }
        int sayac2 = 0; int toplamfiyat = 0;
        private void btnislem_Click(object sender, EventArgs e)
        {
            if (tbAdet.Text != "")
            {
                lvSiparis.Items.Add(listView1.SelectedItems[0].Text.ToString());
                lvSiparis.Items[sayac2].SubItems.Add(adet.ToString());

                lvSiparis.Items[sayac2].SubItems.Add((Convert.ToInt16(fiyat) * adet).ToString());
                toplamfiyat += Convert.ToInt16(fiyat) * adet;
                sayac2++;
                tbAdet.Clear();
                adet = 0;
            }
            
        }

        private void btnodeme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toplam Fiyat: "+toplamfiyat);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Masayı İptal Etmek İstediğinizden Emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                frmMasalar masa = new frmMasalar();
                this.Hide();
                masa.Show();
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            tbAdet.Text = "0";
        }
    }
}
