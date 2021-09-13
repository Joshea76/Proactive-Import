using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class PrivacyRulesDropsOption
    {
        public Guid PrrdoId { get; set; }
        public string Summary { get; set; }
        public string ParentSummary { get; set; }
        public int? ParentId { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }
        public bool PrrdoDeleted { get; set; }
    }
}
