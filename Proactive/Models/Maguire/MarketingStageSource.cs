using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MarketingStageSource
    {
        public Guid StgId { get; set; }
        public Guid SrcId { get; set; }
        public bool? Include { get; set; }
        public short Rank { get; set; }
    }
}
