using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MarketingRecipientCount
    {
        public int MrcId { get; set; }
        public Guid AccId { get; set; }
        public int CsId { get; set; }
        public Guid Type { get; set; }
        public int RunTimes { get; set; }
    }
}
