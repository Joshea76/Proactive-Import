using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class GvvGetAllHighlightRule
    {
        public Guid LfdId { get; set; }
        public Guid RuleId { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }
        public decimal? Comparator { get; set; }
        public Guid? TimeUnitId { get; set; }
        public string TimeSystemName { get; set; }
        public Guid? LogicalOperatorId { get; set; }
        public string LogicalOperatorSystemName { get; set; }
        public string LogicalOperator { get; set; }
        public int FieldType { get; set; }
        public int? SortOrder { get; set; }
    }
}
