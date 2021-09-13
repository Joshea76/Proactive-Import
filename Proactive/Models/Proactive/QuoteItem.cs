using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class QuoteItem
    {
        public int QuoteItemId { get; set; }
        public int QuoteId { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public decimal Rate { get; set; }
        public decimal Quantity { get; set; }
        public int? ProductOrService { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string QuoteItemDescription { get; set; }
        public decimal? ProductValue { get; set; }
        public decimal DiscountPercent { get; set; }

        public virtual Product Product { get; set; }
        public virtual Quote Quote { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
