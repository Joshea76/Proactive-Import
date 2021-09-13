using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VScheduledQuote
    {
        public Guid SchqId { get; set; }
        public Guid SchId { get; set; }
        public Guid OpqId { get; set; }
        public string Summary { get; set; }
        public string AccountName { get; set; }
        public string Wording { get; set; }
        public DateTime? EstimatedClosed { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
