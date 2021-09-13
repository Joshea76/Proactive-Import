using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VMailCampaignAttachment
    {
        public Guid? MacId { get; set; }
        public Guid MacaId { get; set; }
        public bool? MacaDeleted { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
