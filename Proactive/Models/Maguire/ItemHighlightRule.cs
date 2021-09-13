using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class ItemHighlightRule
    {
        public Guid RuleId { get; set; }
        public Guid LfdId { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }
        public decimal? Comparator { get; set; }
        public Guid? TimeUnitId { get; set; }
        public Guid? LogicalOperatorId { get; set; }
        public int? SortOrder { get; set; }
    }
}
