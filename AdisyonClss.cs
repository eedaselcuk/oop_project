using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace nyp2
{
    class AdisyonClss
    {
        Veritabani db = new Veritabani();

        #region fields
        private int _adisyonID;
        private int _ServisTurNo;
        private int _PersonelID;
        private int _masaID;
        private int _tarih;
        private int _durum;

        #endregion

        #region properties
        public int ID
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

        public int ServisTurNo
        {
            get
            {
                return _ServisTurNo;
            }

            set
            {
                _ServisTurNo = value;
            }
        }

        public int PersonelID
        {
            get
            {
                return _PersonelID;
            }

            set
            {
                _PersonelID = value;
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

        public int Tarih
        {
            get
            {
                return _tarih;
            }

            set
            {
                _tarih = value;
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

        public int AdisyonAl(int masaID)
        {
            SqlConnection baglanti = new SqlConnection(db.baglantiString);
            SqlCommand komut = new SqlCommand("Select top 1 From Adisyon Where MasaID=@masaID Order by ID desc", baglanti);

            komut.Parameters.Add("@MasaID", SqlDbType.Int).Value = MasaID;
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                MasaID = Convert.ToInt32(komut.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                baglanti.Close();

            }
            return MasaID;

        } // açık olan masanın adisyon numarası

    }
}
