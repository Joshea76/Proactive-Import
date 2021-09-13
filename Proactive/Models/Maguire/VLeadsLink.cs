using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VLeadsLink
    {
        public int LmlId { get; set; }
        public int LmlCsIdFrom { get; set; }
        public int LmlCsIdTo { get; set; }
        public string LmlRelationship { get; set; }
        public DateTime LmlCreatedDate { get; set; }
        public string LmlCreatedBy { get; set; }
        public bool LmlDeleted { get; set; }
        public string CsFromSummary { get; set; }
        public string CsToSummary { get; set; }
        public string ContactPhoneFrom { get; set; }
        public string ContactPhoneTo { get; set; }
        public string ContactEmailFrom { get; set; }
        public string ContactEmailTo { get; set; }
        public bool CsMigratedFrom { get; set; }
        public bool CsMigratedTo { get; set; }
        public bool? CsDiscardedFrom { get; set; }
        public bool? CsDiscardedTo { get; set; }
        public string ListSummaryFrom { get; set; }
        public string ListSummaryTo { get; set; }
        public string ContactJobtitleFrom { get; set; }
        public string ContactJobtitleTo { get; set; }
    }
}
