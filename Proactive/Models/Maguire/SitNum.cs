using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SitNum
    {
        public Guid SitNumId { get; set; }

        public virtual Site SitNumNavigation { get; set; }
    }
}
