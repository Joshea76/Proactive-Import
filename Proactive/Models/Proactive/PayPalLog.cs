using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class PayPalLog
    {
        public int PayPalLogId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Request { get; set; }
    }
}
