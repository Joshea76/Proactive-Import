using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class LmDeduplicationItem
    {
        public int DiId { get; set; }
        public int DdId { get; set; }
        public int CsId { get; set; }

        public virtual LmContactSpine Cs { get; set; }
        public virtual LmDeduplicationQueue Dd { get; set; }
    }
}
