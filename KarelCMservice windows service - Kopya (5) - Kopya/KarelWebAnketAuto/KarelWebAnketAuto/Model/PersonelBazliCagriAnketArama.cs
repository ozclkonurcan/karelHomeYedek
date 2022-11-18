using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarelWebAnketAuto.Model
{
    public class PersonelBazliCagriAnketArama
    {
        public string ISLEM_NO { get; set; }
        public DateTime TARIH { get; set; }
        public string SAAT { get; set; }
        public string GRUP { get; set; }
        public string AGRUP { get; set; }
        public string ORGANIZASYON { get; set; }
        public string KULLANICI { get; set; }
        public string MUHATAP { get; set; }
        public string AD_SOYAD { get; set; }
        public string TELEFON { get; set; }
        public string CAGRI_TEL { get; set; }
        public bool PersonelBazliCagriDurumType { get; set; }
    }
}
