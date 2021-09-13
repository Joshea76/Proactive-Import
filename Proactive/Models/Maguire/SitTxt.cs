using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SitTxt
    {
        public Guid SitTxtId { get; set; }

        public virtual Site SitTxtNavigation { get; set; }
    }
}
