using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace esun.Models
{
    public class BRIDGE
    {
        public int ID { get; set; }
        public string non_bridge { get; set; }
        public string bridge_id { get; set; }
        public string bridge_name { get; set; }
        public string adm { get; set; }
        public string section { get; set; }
        public string county { get; set; }
        public string town { get; set; }
        public string route { get; set; }
        public string river_cross { get; set; }
        public string double_bridge { get; set; }
        public string designer { get; set; }
        public string engineer { get; set; }
        public string builder { get; set; }
    }
}