using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class EmailJobsRecipient
    {
        public Guid ErId { get; set; }
        public Guid EjId { get; set; }
        public string Email { get; set; }
        public int RecipientType { get; set; }

        public virtual EmailJob Ej { get; set; }
    }
}
