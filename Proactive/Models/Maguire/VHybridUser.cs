using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VHybridUser
    {
        public Guid UsId { get; set; }
        public string Summary { get; set; }
        public string UserGroupName { get; set; }
        public bool HybridEnabled { get; set; }
        public string HybridDefaultMode { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
