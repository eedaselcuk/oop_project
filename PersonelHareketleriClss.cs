using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace nyp2
{
    class PersonelHareketleriClss
    {
        Veritabani db = new Veritabani();
        #region  fields
        private int _ID;
        private int _PersonelID;
        private string _islem;
        private DateTime _tarih;
        private bool _durum;
        #endregion

        #region  properties 
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

        public string Islem
        {
            get
            {
                return _islem;
            }

            set
            {
                _islem = value;
            }
        }

        public DateTime Tarih
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

        public bool Durum
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

        public bool PersonelHareketKayit(PersonelHareketleriClss ph) 
        {
            bool sonuc = false;
            SqlConnection baglanti = new SqlConnection(db.baglantiString);
            SqlCommand komut = new SqlCommand("Insert into PersonelHareket(PersonelID, islem, tarih)Values(@PersonelID, @islem,@tarih)", baglanti);


            try
            {
                if (baglanti.State==ConnectionState.Closed)
                {
                    baglanti.Open();

                }

                komut.Parameters.Add("@PersonelID", SqlDbType.Int).Value = ph._PersonelID;
                komut.Parameters.Add("@islem", SqlDbType.VarChar).Value = ph._islem;
                komut.Parameters.Add("@tarih", SqlDbType.DateTime).Value = ph._tarih;

                sonuc = Convert.ToBoolean(komut.ExecuteNonQuery()); 
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            return sonuc;
        }
    }
}
