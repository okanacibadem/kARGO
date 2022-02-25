using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP.ORM.Entity
{
    public class MusteriTable
    {
        public int MusteriId { get; set; }
        public string MusteriAdsoyad { get; set; }      
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string   Mail { get; set; }
        public string ÖdemeDurumu { get; set; }
        public int SevkıyatId { get; set; }
       
    }
}
