using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class JobItem
    {
        public int JobItemId { get; set; }
        public int JobHeaderId { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public decimal Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime? DoByDate { get; set; }
        public int? ItemStatus { get; set; }
        public string UserId { get; set; }
        public DateTime? DateDone { get; set; }
        public string Note { get; set; }
        public int? JobHours { get; set; }
        public int? JobMinutes { get; set; }
        public int? ProductOrService { get; set; }
        public int? JobJobId { get; set; }
        public int? InvoiceIdtemp { get; set; }
        public string TempjobId { get; set; }

        public virtual JobHeader JobHeader { get; set; }
        public virtual Job JobJob { get; set; }
        public virtual Product Product { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
