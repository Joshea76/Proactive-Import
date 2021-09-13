using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MailCampaignsAttachment
    {
        public Guid? MacId { get; set; }
        public Guid MacaId { get; set; }
        public bool? MacaDeleted { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public byte[] Body { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }

        public virtual MailCampaign Mac { get; set; }
    }
}
