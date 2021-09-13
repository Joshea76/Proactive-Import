using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class ScheduledQuotesChangeHistory
    {
        public Guid SqhId { get; set; }
        public Guid? SchqId { get; set; }
        public Guid? OpqdId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QuoteTotal { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int? Status { get; set; }
    }
}
