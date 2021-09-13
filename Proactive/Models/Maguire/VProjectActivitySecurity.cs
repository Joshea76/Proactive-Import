using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VProjectActivitySecurity
    {
        public Guid PjId { get; set; }
        public string UserSummary { get; set; }
        public Guid UsId { get; set; }
        public int CanSeeObject { get; set; }
        public string VisibilityReason { get; set; }
        public Guid PjaId { get; set; }
    }
}
