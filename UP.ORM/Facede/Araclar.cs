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
    public class Araclar
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("ListeleArac", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Sil(Arac usil)
        {
            SqlCommand sil = new SqlCommand("SilArac", Tools.Baglanti);
            sil.CommandType = CommandType.StoredProcedure;
            sil.Parameters.AddWithValue("AracId", usil.AracId);
            return Tools.ExecuteNonQuery(sil);
        }

        public static bool Ekle(Arac uekle)
        {
            SqlCommand ekle = new SqlCommand("ekleArac", Tools.Baglanti);
            ekle.CommandType = CommandType.StoredProcedure;
            ekle.Parameters.AddWithValue("AracTuru", uekle.AracTuru);
            ekle.Parameters.AddWithValue("AracKapasitesi", uekle.AracKapasitesi);
            ekle.Parameters.AddWithValue("AracSoförü", uekle.AracSoförü);
            return Tools.ExecuteNonQuery(ekle);
        }
        public static bool Yenile(Arac güncelle)
        {
            SqlCommand güncelleKOMUT = new SqlCommand("GüncelleArac", Tools.Baglanti);
            güncelleKOMUT.CommandType = CommandType.StoredProcedure;
            güncelleKOMUT.Parameters.AddWithValue("AracId", güncelle.AracId);
            güncelleKOMUT.Parameters.AddWithValue("AracTuru", güncelle.AracTuru);
            güncelleKOMUT.Parameters.AddWithValue("AracKapasitesi", güncelle.AracKapasitesi);
            güncelleKOMUT.Parameters.AddWithValue("AracSoförü", güncelle.AracSoförü);
            return Tools.ExecuteNonQuery(güncelleKOMUT);
        }

    }
}
