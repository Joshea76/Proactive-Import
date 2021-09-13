using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class ContactSalesStep
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public int StepId { get; set; }
        public int? SalesProcessId { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserId { get; set; }
    }
}
