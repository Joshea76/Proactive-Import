using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class PayPalTransaction
    {
        public int PayPalTransactionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UserId { get; set; }
        public string PayerEmail { get; set; }
        public string TransactionId { get; set; }
        public string TransactionType { get; set; }
        public string PaymentStatus { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal McGross { get; set; }
        public decimal McFee { get; set; }

        public virtual ProviderPayment ProviderPayment { get; set; }
    }
}
