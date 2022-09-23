using System;
using System.Collections.Generic;

#nullable disable

namespace ReturnMgmt.Models
{
    public partial class Processdetail
    {
        public int Did { get; set; }
        public int Tranid { get; set; }
        public string Componenttype { get; set; }
        public string Componentname { get; set; }
        public int? Quantity { get; set; }
        public bool? Ispriority { get; set; }
    }
}
