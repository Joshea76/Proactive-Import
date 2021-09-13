using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SrcTxt
    {
        public Guid SrcTxtId { get; set; }

        public virtual MarketingSource SrcTxtNavigation { get; set; }
    }
}
