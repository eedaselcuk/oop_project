using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace nyp2
{
    class PersonelClass
    {
        Veritabani db = new Veritabani(); //database class'ındaki verilere ulaşmak için 

        #region Fields
        private int _PersonelId; 
        private int _GorevId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelParola;
        private string _PersonelKullaniciAd;
        private bool _PersonelDurum;
        private string UserId;
        private string UserPassword;
        internal int _personelId;
        #endregion

        #region Properties
        public int PersonelId
        {
            get
            {
                return _PersonelId;
            }

            set
            {
                _PersonelId = value;
            }
        }

        public int GorevId
        {
            get
            {
                return _GorevId;
            }

            set
            {
                _GorevId = value;
            }
        }

        public string PersonelAd
        {
            get
            {
                return _PersonelAd;
            }

            set
            {
                _PersonelAd = value;
            }
        }

        public string PersonelSoyad
        {
            get
            {
                return _PersonelSoyad;
            }

            set
            {
                _PersonelSoyad = value;
            }
        }

        public string PersonelParola
        {
            get
            {
                return _PersonelParola;
            }

            set
            {
                _PersonelParola = value;
            }
        }

        public string PersonelKullaniciAd
        {
            get
            {
                return _PersonelKullaniciAd;
            }

            set
            {
                _PersonelKullaniciAd = value;
            }
        }

        public bool PersonelDurum
        {
            get
            {
                return _PersonelDurum;
            }

            set
            {
                _PersonelDurum = value;
            }
        }
        #endregion

        public bool personelGirisKontrol(string sifre, int kullaniciID)
        {
            bool sonuc = false;
            SqlConnection baglanti = new SqlConnection(db.baglantiString);
            SqlCommand komut = new SqlCommand("Select * from personeller where ID=@ID and PAROLA=@sifre", baglanti);

            // personel tablosundaki id de parolayı karşılaştracak
            komut.Parameters.AddWithValue("ID", kullaniciID);
            komut.Parameters.AddWithValue("sifre", sifre);
           // komut.Parameters.Add("@", SqlDbType.VarChar).Value = UserId;
          //  komut.Parameters.Add("@sifre", SqlDbType.VarChar).Value = UserPassword;

            try
            {
                if (baglanti.State == ConnectionState.Closed) 
                {
                    baglanti.Open();
                }
                sonuc = Convert.ToBoolean(komut.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
             //   throw;
            }

            return sonuc;

        }

        public void personelBilgiGetir(ComboBox cb) 
        {
            cb.Items.Clear();
            SqlConnection baglanti = new SqlConnection(db.baglantiString);
            SqlCommand komut = new SqlCommand("Select * from personeller", baglanti);
                    // personel tablosundaki id de parolayı karşılaştracak

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlDataReader verioku = komut.ExecuteReader();

                while (verioku.Read())
                {
                    PersonelClass p = new PersonelClass();
                    p._PersonelId = Convert.ToInt32(verioku["ID"]);
                    p.GorevId = Convert.ToInt32(verioku["GorevID"]);
                    p._PersonelAd = Convert.ToString(verioku["Ad"]);
                    p._PersonelSoyad = Convert.ToString(verioku["Soyad"]);
                    p._PersonelParola = Convert.ToString(verioku["Parola"]);
                    p._PersonelKullaniciAd = Convert.ToString(verioku["KullaniciAd"]);
                    p._PersonelDurum = Convert.ToBoolean(verioku["Durum"]);
                    
                    cb.Items.Add(p);

                }

                verioku.Close();
                baglanti.Close();


            }   finally { }

    }

        public override string ToString()
        {
            return _PersonelAd + " " + _PersonelSoyad;
        }
    }
}
