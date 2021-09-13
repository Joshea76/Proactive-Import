using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class OpTxt
    {
        public Guid OpTxtId { get; set; }

        public virtual Opportunity OpTxtNavigation { get; set; }
    }
}
