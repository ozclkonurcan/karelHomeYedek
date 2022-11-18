using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarelWebAnketAuto.VM_Model
{
    public class ApiAddToCampJson
    {
        public string CampID { get; set; }
        public string CustName { get; set; }
        public string CustPhone { get; set; }
        public string CustData1 { get; set; }
        public bool DurumType { get; set; }
    }
}
