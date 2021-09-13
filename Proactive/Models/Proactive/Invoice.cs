using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceItems = new HashSet<InvoiceItem>();
            InvoicePayments = new HashSet<InvoicePayment>();
        }

        public int InvoiceId { get; set; }
        public string ContactNote { get; set; }
        public string MyNote { get; set; }
        public int InvoiceNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateSent { get; set; }
        public DateTime? DatePaid { get; set; }
        public DateTime DatePaymentDue { get; set; }
        public string UserId { get; set; }
        public int? ContactId { get; set; }
        public decimal VatRate { get; set; }
        public bool ChargeVat { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual AspNetUser User { get; set; }
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
        public virtual ICollection<InvoicePayment> InvoicePayments { get; set; }
    }
}
