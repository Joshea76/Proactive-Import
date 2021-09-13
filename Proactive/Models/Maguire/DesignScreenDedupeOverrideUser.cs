using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignScreenDedupeOverrideUser
    {
        public Guid DscId { get; set; }
        public Guid UsId { get; set; }

        public virtual User Us { get; set; }
    }
}
