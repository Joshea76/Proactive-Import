using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class TouchpointConfiguration
    {
        public TouchpointConfiguration()
        {
            TouchpointFilters = new HashSet<TouchpointFilter>();
            TouchpointLinks = new HashSet<TouchpointLink>();
            Touchpoints = new HashSet<Touchpoint>();
        }

        public int TpcId { get; set; }
        public Guid TpiId { get; set; }
        public string TpcName { get; set; }
        public string IntegrationName { get; set; }
        public bool IsActive { get; set; }
        public DateTime Lastrun { get; set; }
        public int Interval { get; set; }
        public int InitialScore { get; set; }
        public int DegradeRate { get; set; }
        public int DegradeScore { get; set; }
        public int DropOffRate { get; set; }
        public bool? CheckContact { get; set; }
        public bool? CheckAccount { get; set; }
        public bool? CheckLead { get; set; }
        public string ContactKeyGv { get; set; }
        public string AccountKeyGv { get; set; }
        public string LeadKeyGv { get; set; }
        public string Icon { get; set; }
        public int? TptId { get; set; }
        public int? LcId { get; set; }
        public int? CreateOption { get; set; }
        public int? Rank { get; set; }
        public bool? TpcDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? LastTouchpointDate { get; set; }
        public DateTime? LastImported { get; set; }
        public bool? UseAllSocial { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TouchpointFilter> TouchpointFilters { get; set; }
        public virtual ICollection<TouchpointLink> TouchpointLinks { get; set; }
        public virtual ICollection<Touchpoint> Touchpoints { get; set; }
    }
}
