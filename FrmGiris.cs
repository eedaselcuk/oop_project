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
    public partial class FrmGrs : Form

    {
        public FrmGrs()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void FrmGrs_Load(object sender, EventArgs e)
        {
                    //sayfa yükleniğinde combobox a getirsin 
            PersonelClass p = new PersonelClass();
            p.personelBilgiGetir(cbKullanici);
            
        }

        private void btnGrs_Click(object sender, EventArgs e)
        {
            Veritabani db = new Veritabani();
            PersonelClass p = new PersonelClass();
            //hata adamın idsini almadan sorgu yapmsıın o yanı sız sonranda elamn eklersenzı bu yapı coker sımdılık bısey yapcam ama hocanın yanında elamn eklesenız bıle sılmeyın k mu ?OK
            int girenid = cbKullanici.SelectedIndex + 1;
            bool sonuc = p.personelGirisKontrol(txtSifre.Text, girenid);

            //burdan bı gırıs yapmaya calsııyosun evet burası giriş ekranının
            //kontrol false oldugu ıcın gırmıyo oraya bakcam sımdı

            if (sonuc)
            {
                PersonelHareketleriClss hareket = new PersonelHareketleriClss();
            //    hareket.PersonelID= Veritabani._personelId;//bu clasın ıncnde personel ıd dıye bıey yok nerden almaya calsıtın
                hareket.Islem = "Giriş Yapıldı";
                hareket.Tarih = DateTime.Now;
                hareket.PersonelHareketKayit(hareket);

                FrmMenu menu = new FrmMenu();
                
                menu.Show();
                this.Hide();
            }
            else
            {

            }
            
        }

         private void cbKullanici_ (object sender, EventArgs e)
        {

            Veritabani db = new Veritabani();
            PersonelClass p = (PersonelClass)cbKullanici.SelectedItem;
            db._personelId = p._personelId;
            db.GorevId = p.GorevId;
        }

        


        private void btnCik_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin misiniz?","Uyarı!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
