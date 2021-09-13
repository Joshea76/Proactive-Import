using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class ProviderPayment
    {
        public int ProviderPaymentId { get; set; }
        public string UserId { get; set; }
        public string TransactionId { get; set; }
        public bool IsPaid { get; set; }
        public DateTime? DatePaid { get; set; }

        public virtual PayPalTransaction ProviderPaymentNavigation { get; set; }
    }
}
