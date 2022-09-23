using System;
using System.Collections.Generic;

#nullable disable

namespace RtMgmt.Models
{
    public partial class RtnPriceMaster
    {
        public int Id { get; set; }
        public string Servicetype { get; set; }
        public string Items { get; set; }
        public decimal? Cost { get; set; }
    }
}
