using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace nyp2
{
    class masalarClss
    {
        #region fields
        private int _ID;
        private int _kapasite;
        private int _Durum;
        private int _servisTur;
        private int _onay;
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

        public int Kapasite
        {
            get
            {
                return _kapasite;
            }

            set
            {
                _kapasite = value;
            }
        }

        public int Durum
        {
            get
            {
                return _Durum;
            }

            set
            {
                _Durum = value;
            }
        }

        public int ServisTur
        {
            get
            {
                return _servisTur;
            }

            set
            {
                _servisTur = value;
            }
        }

        public int Onay
        {
            get
            {
                return _onay;
            }

            set
            {
                _onay = value;
            }
        }
        #endregion

        Veritabani db = new Veritabani();

        public string SessionSum(int state)
        {


            string dt = "";
            SqlConnection baglanti = new SqlConnection(db.baglantiString);
            SqlCommand komut = new SqlCommand("Select tarih,masaID From Adisyon Right Join masalar on Adisyon.masaID=masalar.ID Where Masalar.Durum=@durum and Adisyon.Durum=0", baglanti);

            SqlDataReader verioku = null;
            komut.Parameters.Add("@durum", SqlDbType.Int).Value = state;

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();

                }
                verioku = komut.ExecuteReader();
                while (verioku.Read())
                {
                    dt = Convert.ToDateTime(verioku["tarih"]).ToString();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

                throw;
            }
            finally
            {
                verioku.Close();
                baglanti.Dispose();
                baglanti.Close();

            }

            return dt;

        }

        public int MasaNumarasiAl(string MasaDeger)
        {
            string aa = MasaDeger;
            int length = aa.Length;
            
            return Convert.ToInt32(aa.Substring(length - 1, 1));

        }

        public bool MasaDurumAl(int ButonAd, int durum)
        {
            bool sonuc = false;
            SqlConnection baglanti = new SqlConnection(db.baglantiString);
            SqlCommand komut = new SqlCommand("Select Durum from masalar Where ID=@MasaID and Durum=@Durum", baglanti);

            komut.Parameters.Add("@MasaID", SqlDbType.Int).Value = ButonAd;
            komut.Parameters.Add("@Durum", SqlDbType.Int).Value = _Durum;
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
            }
            finally
            {
                baglanti.Dispose();
                baglanti.Close();

            }
            return sonuc;


        }
    }
}
