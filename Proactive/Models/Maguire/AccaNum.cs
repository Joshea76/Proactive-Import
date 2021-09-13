using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AccaNum
    {
        public Guid AccaNumId { get; set; }

        public virtual Activity AccaNumNavigation { get; set; }
    }
}
