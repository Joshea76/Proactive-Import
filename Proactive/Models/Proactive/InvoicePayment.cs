using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class InvoicePayment
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal Amount { get; set; }
        public string UserId { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
