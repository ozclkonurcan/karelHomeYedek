using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarelWebAnketAuto.Model
{
    public class Enerya_Anket_Arama
    {
        public string MANDT { get; set; }
        public DateTime TARIH { get; set; }
        public string SOZHESAP { get; set; }
        public string SURECADI { get; set; }
        public string PERADSOYAD { get; set; }
        public string MUSADSOYAD { get; set; }
        public string CEPTEL { get; set; }
        public string USER { get; set; }
        public string LOKASYON { get; set; }
        public string SEHIR { get; set; }

        public bool durumType { get; set; }
    }
}
