using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace restorantotomasyonu
{
    internal class cPersoneller
    {
        cGenel gnl = new cGenel(); //daha kolay olsun diye gnl yaptık kısayolunu
        #region Fields
        private int _PersonelId;
        private int _PersonelGorevId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private int _PersonelParola;
        private string _PersonelKullanıcıAdı;
        private bool _PersonelDurum;
        #endregion
        #region Properties
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int PersonelGorevId { get => _PersonelGorevId; set => _PersonelGorevId = value; }
        public string PersonelAd { get => _PersonelAd; set => _PersonelAd = value; }
        public string PersonelSoyad { get => _PersonelSoyad; set => _PersonelSoyad = value; }
        public int PersonelParola { get => _PersonelParola; set => _PersonelParola = value; }
        public string PersonelKullanıcıAdı { get => _PersonelKullanıcıAdı; set => _PersonelKullanıcıAdı = value; }
        public bool PersonelDurum { get => _PersonelDurum; set => _PersonelDurum = value; }
        #endregion

        public bool PersonelEnrtyControl(string password, int UserId)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString); //Burda veri tabanına bağlanıyoruz.
            SqlCommand cmd = new SqlCommand("Select * from personeller where ID=@Id and PAROLA=@Password", con); //Gelen ıd ve şifreyi kontrol ediyoruz.
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = UserId; //önce bu ikisi çalıştı 
            cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }

            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            return result;
        }
        public void personelGetbyInformation (ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString); //Burda veri tabanına bağlanıyoruz.
            SqlCommand cmd = new SqlCommand("Select * from personeller" , con); //Gelen ıd ve şifreyi kontrol ediyoruz.

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                cPersoneller p = new cPersoneller();
                p._PersonelId = Convert.ToInt32(dr["ID"]);
                p._PersonelGorevId = Convert.ToInt32(dr["GOREVID"]);
                p._PersonelAd = Convert.ToString(dr["AD"]);
                p._PersonelSoyad = Convert.ToString(dr["SOYAD"]);
                p._PersonelKullanıcıAdı = Convert.ToString(dr["KULLANICIADI"]);
                p._PersonelDurum = Convert.ToBoolean(dr["DURUM"]);
                cb.Items.Add(p);
            }
            dr.Close();
            con.Close();
            

        }
        public override string ToString()
        {
            return PersonelAd + " " + PersonelSoyad;
        }

    }
        
}



