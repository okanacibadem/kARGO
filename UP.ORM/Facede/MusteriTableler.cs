using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using UP.ORM.Entity;

namespace UP.ORM.Facede
{
  public  class MusteriTableler
    {
        public static DataTable ListeleM()
        {
            SqlDataAdapter adp = new SqlDataAdapter("ListeleMusteriTable", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
  

        public static bool SilM(MusteriTable usil)
        {
            SqlCommand sil = new SqlCommand("SilMusteriTable", Tools.Baglanti);
            sil.CommandType = CommandType.StoredProcedure;
            sil.Parameters.AddWithValue("MusteriId", usil.MusteriId);
            return Tools.ExecuteNonQuery(sil);
        }

        public static bool EkleM(MusteriTable uekle)
        {
            SqlCommand ekle = new SqlCommand("ekleMusteriTable", Tools.Baglanti);
            ekle.CommandType = CommandType.StoredProcedure;
            ekle.Parameters.AddWithValue("MusteriAdsoyad", uekle.MusteriAdsoyad);
            ekle.Parameters.AddWithValue("Adres", uekle.Adres);
            ekle.Parameters.AddWithValue("Telefon", uekle.Telefon);
            ekle.Parameters.AddWithValue("Mail", uekle.Mail);
            ekle.Parameters.AddWithValue("ÖdemeDurumu", uekle.ÖdemeDurumu);
            ekle.Parameters.AddWithValue("SevkıyatId", uekle.SevkıyatId);
            return Tools.ExecuteNonQuery(ekle);
        }
        public static bool YenileM(MusteriTable güncelle)
        {
            SqlCommand güncelleKOMUT = new SqlCommand("GüncelleMusteriTable", Tools.Baglanti);
            güncelleKOMUT.CommandType = CommandType.StoredProcedure;
            güncelleKOMUT.Parameters.AddWithValue("MusteriId", güncelle.MusteriId);
            güncelleKOMUT.Parameters.AddWithValue("MusteriAdsoyad", güncelle.MusteriAdsoyad);
            güncelleKOMUT.Parameters.AddWithValue("Adres", güncelle.Adres);
            güncelleKOMUT.Parameters.AddWithValue("Telefon", güncelle.Telefon);
            güncelleKOMUT.Parameters.AddWithValue("Mail", güncelle.Mail);
            güncelleKOMUT.Parameters.AddWithValue("ÖdemeDurumu", güncelle.ÖdemeDurumu);
            güncelleKOMUT.Parameters.AddWithValue("SevkıyatId", güncelle.SevkıyatId);
            return Tools.ExecuteNonQuery(güncelleKOMUT);
        }







    }

}