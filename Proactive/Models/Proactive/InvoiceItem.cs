using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class InvoiceItem
    {
        public int InvoiceItemId { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public decimal Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? JobHours { get; set; }
        public int? JobMinutes { get; set; }
        public int ProductId { get; set; }
        public int? ProductOrService { get; set; }
        public string UserId { get; set; }
        public int InvoiceId { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
