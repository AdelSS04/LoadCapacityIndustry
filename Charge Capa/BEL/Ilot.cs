using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Ilot
    {
        public string IlotID { get; set; }
        public string IlotName { get; set; }
        public float Efficiency { get; set; }
        public float CRM { get; set; }
        public float TruancyRate   { get; set; }
        public float IlotRejectedRate { get; set; }
        public string UserID { get; set; }
    }
}
