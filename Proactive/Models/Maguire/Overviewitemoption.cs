using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Overviewitemoption
    {
        public Guid OioId { get; set; }
        public Guid AcoId { get; set; }
        public bool? Enabled { get; set; }
        public string ScreenName { get; set; }
        public string RegionName { get; set; }
        public string ItemName { get; set; }
        public string ItemNameRef { get; set; }
        public string LightImage { get; set; }
        public string DarkImage { get; set; }
        public string OnclickFunction { get; set; }
        public string OnclickParam { get; set; }
        public string ItemLinkFunction { get; set; }
        public string ItemLinkParam { get; set; }
        public int? ItemOrder { get; set; }
        public string NewLinkFunction { get; set; }
        public string NewLinkParam { get; set; }
        public string ClassExtension { get; set; }
    }
}
