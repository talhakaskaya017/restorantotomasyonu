using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restorantotomasyonu
{
    internal class cMasalar
    {
        #region Fields
        private int _ID;
        private int _KAPASITE;
        private int _SERVİSTURU;
        private int _DURUM;
        private int _ONAY;
        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int KAPASITE { get => _KAPASITE; set => _KAPASITE = value; }
        public int SERVİSTURU { get => _SERVİSTURU; set => _SERVİSTURU = value; }
        public int DURUM { get => _DURUM; set => _DURUM = value; }
        public int ONAY { get => _ONAY; set => _ONAY = value; }
        #endregion
        cGenel gnl = new cGenel();
        public string SessionSum(int state)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select TARIH,MASAID From adisyon Right Join masalar on adisyon.MASAID=masalar.ID where masalar.DURUM=@durum and adisyon.Durum=0", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@durum",SqlDbType.Int).Value= state;
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["TARIH"]).ToString();
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
            return dt;
        }
    }
   
}
