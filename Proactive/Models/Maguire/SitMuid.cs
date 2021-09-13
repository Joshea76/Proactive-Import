using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SitMuid
    {
        public Guid SitMuidId { get; set; }

        public virtual Site SitMuidNavigation { get; set; }
    }
}
