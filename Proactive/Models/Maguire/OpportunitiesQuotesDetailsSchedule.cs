using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class OpportunitiesQuotesDetailsSchedule
    {
        public Guid OdsId { get; set; }
        public Guid OpqdId { get; set; }
        public int? Month { get; set; }
        public decimal? Percent { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
