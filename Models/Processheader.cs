using System;
using System.Collections.Generic;

#nullable disable

namespace RtMgmt.Models
{
    public partial class Processheader
    {
        public int Tranid { get; set; }
        public string Username { get; set; }
        public decimal? Contactnumber { get; set; }
        public decimal? Creditcardnumber { get; set; }
        public DateTime? Trandate { get; set; }
        public DateTime? Expecteddeliverydate { get; set; }
        public string Componenttype { get; set; }
        public string Componentname { get; set; }
        public int? Quantity { get; set; }
        public bool? Ispriority { get; set; }
    }
}
