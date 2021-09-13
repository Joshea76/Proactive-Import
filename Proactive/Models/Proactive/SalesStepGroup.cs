using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class SalesStepGroup
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string GroupDesc { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
