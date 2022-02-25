using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP.ORM.Entity
{
   public class SevkTable
    {
        public int SevkId { get; set; }
        public string SevkiyatAdı { get; set; }
        public string SevkAlınanNokta { get; set; }
        public string SevkUlasılacakNokta { get; set; }
        public int Mesafe { get; set; }
        public int MesafeTutarı { get; set; }
        public int AracId { get; set; }
    }
}
