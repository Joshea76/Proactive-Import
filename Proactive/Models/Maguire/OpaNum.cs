using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class OpaNum
    {
        public Guid OpaNumId { get; set; }

        public virtual Activity OpaNumNavigation { get; set; }
    }
}
