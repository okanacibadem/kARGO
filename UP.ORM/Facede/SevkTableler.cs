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
    public class SevkTableler
    {

        public static DataTable Listeles()
        {
            SqlDataAdapter adp = new SqlDataAdapter("ListeleSevkTable", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }



        public static bool SilS(SevkTable usil)
        {
            SqlCommand sil = new SqlCommand("SilSevkTable", Tools.Baglanti);
            sil.CommandType = CommandType.StoredProcedure;
            sil.Parameters.AddWithValue("SevkId", usil.SevkId);
            return Tools.ExecuteNonQuery(sil);
        }
        public static bool EkleS(SevkTable uekle)
        {
            SqlCommand ekle = new SqlCommand("ekleSevkTable", Tools.Baglanti);
            ekle.CommandType = CommandType.StoredProcedure;
            ekle.Parameters.AddWithValue("SevkiyatAdı", uekle.SevkiyatAdı);
            ekle.Parameters.AddWithValue("SevkAlınanNokta", uekle.SevkAlınanNokta);
            ekle.Parameters.AddWithValue("SevkUlasılacakNokta", uekle.SevkUlasılacakNokta);
            ekle.Parameters.AddWithValue("Mesafe", uekle.Mesafe);
            ekle.Parameters.AddWithValue("MesafeTutarı", uekle.MesafeTutarı);
            ekle.Parameters.AddWithValue("AracId", uekle.AracId);
            return Tools.ExecuteNonQuery(ekle);
        }
        public static bool YenileS(SevkTable güncelle)
        {
            SqlCommand güncelleKOMUT = new SqlCommand("GüncelleSevkTable", Tools.Baglanti);
            güncelleKOMUT.CommandType = CommandType.StoredProcedure;
            güncelleKOMUT.Parameters.AddWithValue("SevkId", güncelle.SevkId);
            güncelleKOMUT.Parameters.AddWithValue("SevkiyatAdı", güncelle.SevkiyatAdı);
            güncelleKOMUT.Parameters.AddWithValue("SevkAlınanNokta", güncelle.SevkAlınanNokta);
            güncelleKOMUT.Parameters.AddWithValue("SevkUlasılacakNokta", güncelle.SevkUlasılacakNokta); 
                  güncelleKOMUT.Parameters.AddWithValue("Mesafe", güncelle.Mesafe); 
                  güncelleKOMUT.Parameters.AddWithValue("MesafeTutarı", güncelle.MesafeTutarı); 
                güncelleKOMUT.Parameters.AddWithValue("AracId", güncelle.AracId);
            return Tools.ExecuteNonQuery(güncelleKOMUT);
        }

    }
}
