using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class LmDuplicateEntity
    {
        public int DeId { get; set; }
        public int CsId1 { get; set; }
        public int CsId2 { get; set; }
        public int DuplicateScore { get; set; }
        public string DuplicateNarrative { get; set; }
        public string DuplicateRule { get; set; }
        public DateTime CreatedDate { get; set; }
        public int RuleId { get; set; }
        public int DdId { get; set; }
        public int? LcId1 { get; set; }
        public int? LcId2 { get; set; }

        public virtual LmContactSpine CsId1Navigation { get; set; }
        public virtual LmContactSpine CsId2Navigation { get; set; }
        public virtual LmDeduplicationQueue Dd { get; set; }
    }
}
