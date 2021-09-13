using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AccDate
    {
        public Guid AccDateId { get; set; }

        public virtual AccountsContact AccDateNavigation { get; set; }
    }
}
