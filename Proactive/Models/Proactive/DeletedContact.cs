using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class DeletedContact
    {
        public int DeletedContactId { get; set; }
        public int ContactId { get; set; }
        public DateTime DateDeleted { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
