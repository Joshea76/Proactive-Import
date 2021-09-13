using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VMailCampaignsSource
    {
        public Guid McsId { get; set; }
        public Guid? MacId { get; set; }
        public string SourceQuery { get; set; }
        public string Summary { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastRefresh { get; set; }
        public bool? ManualDelete { get; set; }
        public bool? ManualAdd { get; set; }
        public Guid? OldId { get; set; }
        public Guid? McsIdNullable { get; set; }
    }
}
