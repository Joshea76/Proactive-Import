using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AccNum
    {
        public Guid AccNumId { get; set; }

        public virtual AccountsContact AccNumNavigation { get; set; }
    }
}
