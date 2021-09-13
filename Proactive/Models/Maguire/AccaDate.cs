using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AccaDate
    {
        public Guid AccaDateId { get; set; }

        public virtual Activity AccaDateNavigation { get; set; }
    }
}
