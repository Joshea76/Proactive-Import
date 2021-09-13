using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AccaTxt
    {
        public Guid AccaTxtId { get; set; }

        public virtual Activity AccaTxtNavigation { get; set; }
    }
}
