using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class SkypeCall
    {
        public int SkypeCallId { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserId { get; set; }
        public int ContactId { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
