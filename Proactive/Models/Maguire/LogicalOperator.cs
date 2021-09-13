using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class LogicalOperator
    {
        public Guid LogicalOperatorId { get; set; }
        public string SystemName { get; set; }
        public string LogicalOperator1 { get; set; }
        public int FieldType { get; set; }
        public bool IsMinus { get; set; }
    }
}
