using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Machine
    {
        public string MachineID { get; set; }
        public string MachineName { get; set; }
        public string Etat { get; set; }
       
        public float MachineRejectedRate { get; set; }
    }
}
