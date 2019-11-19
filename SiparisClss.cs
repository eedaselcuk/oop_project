using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace nyp2
{
    class SiparisClss
    {
        Veritabani db = new Veritabani();

        #region fields
        private int _ID;
        private int _urunID;
        private int _adisyonID;
        private int _masaID;
        private int _adet;
        private int _durum;
        #endregion
        #region properties
        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }

        public int UrunID
        {
            get
            {
                return _urunID;
            }

            set
            {
                _urunID = value;
            }
        }

        public int AdisyonID
        {
            get
            {
                return _adisyonID;
            }

            set
            {
                _adisyonID = value;
            }
        }

        public int MasaID
        {
            get
            {
                return _masaID;
            }

            set
            {
                _masaID = value;
            }
        }

        public int Adet
        {
            get
            {
                return _adet;
            }

            set
            {
                _adet = value;
            }
        }

        public int Durum
        {
            get
            {
                return _durum;
            }

            set
            {
                _durum = value;
            }
        }
        #endregion

        //sipariş getireceğiz;
        public void SiparisGetir(ListView lv, int _adisyonID)
        {
            SqlConnection baglanti = new SqlConnection(db.baglantiString);
            SqlCommand komut = new SqlCommand("Select URUNAD,SAtislar.ID,Satislar.urunID,Satislar.adet,Urunler.FIYAT from Satislar Inner Join Urunler on Satislar.urunID=Urunler.ID Where adisyonID=@adisyonID", baglanti);
            SqlDataReader verioku = null;

            komut.Parameters.Add("@MasaID", SqlDbType.Int).Value = MasaID;
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                verioku = komut.ExecuteReader();
                int sayac = 0;
                while (verioku.Read())
                {
                    lv.Items.Add(verioku["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(verioku["adet"].ToString());
                    lv.Items[sayac].SubItems.Add(verioku["urunID"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(verioku["FIYAT"]) * Convert.ToDecimal(verioku["adet"])));
                    lv.Items[sayac].SubItems.Add(verioku["ID"].ToString());

                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                verioku.Close();
                baglanti.Dispose();
                baglanti.Close();

            }
        }

    }
}
