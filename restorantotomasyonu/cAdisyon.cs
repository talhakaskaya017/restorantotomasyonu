﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restorantotomasyonu
{
    internal class cAdisyon
    { 
        cGenel gnl = new cGenel();
        #region Fields
        private int _ID;
        private int _ServisTurNo;
        private decimal _Tutar;
        private DateTime _Tarih;
        private int _PersonelId;
        private int _Durum;
        private int _MasaId;
        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int ServisTurNo { get => _ServisTurNo; set => _ServisTurNo = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int Durum { get => _Durum; set => _Durum = value; }
        public int MasaId { get => _MasaId; set => _MasaId = value; }
        #endregion
        public int getByAddition(int MasaId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 ID From adisyon Where MASAID=@MasaId Order by ID desc", con);

            cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = MasaId;
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                MasaId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata=ex.Message;
            }
            finally
            {
                con.Close();
            }
            return MasaId;
        } // Açık olan masanın adisyon numarası

    }
}
