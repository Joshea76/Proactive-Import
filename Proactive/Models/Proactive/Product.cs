using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Product
    {
        public Product()
        {
            InvoiceItems = new HashSet<InvoiceItem>();
            JobItems = new HashSet<JobItem>();
            Opportunities = new HashSet<Opportunity>();
            QuoteItems = new HashSet<QuoteItem>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string UserId { get; set; }
        public int Unit { get; set; }
        public int DisplayProduct { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal Price { get; set; }
        public int ProductOrService { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
        public virtual ICollection<JobItem> JobItems { get; set; }
        public virtual ICollection<Opportunity> Opportunities { get; set; }
        public virtual ICollection<QuoteItem> QuoteItems { get; set; }
    }
}
