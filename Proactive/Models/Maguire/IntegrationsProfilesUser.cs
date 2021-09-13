using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class IntegrationsProfilesUser
    {
        public Guid SiId { get; set; }
        public Guid SipId { get; set; }
        public Guid SipuId { get; set; }
        public Guid UsId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool Enabled { get; set; }
    }
}
