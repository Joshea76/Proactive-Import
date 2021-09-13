using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AcpTxt
    {
        public Guid AcpTxtId { get; set; }

        public virtual AccountsProfile AcpTxtNavigation { get; set; }
    }
}
