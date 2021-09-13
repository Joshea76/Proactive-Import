using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class OpqTxt
    {
        public Guid OpqTxtId { get; set; }

        public virtual OpportunitiesQuote OpqTxtNavigation { get; set; }
    }
}
