using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SitDate
    {
        public Guid SitDateId { get; set; }

        public virtual Site SitDateNavigation { get; set; }
    }
}
