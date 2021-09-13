using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class LmMailRunClickdatum
    {
        public Guid LmrcId { get; set; }
        public Guid LmrrId { get; set; }
        public Guid LmrId { get; set; }
        public int CsId { get; set; }
        public DateTime? DateClicked { get; set; }
        public string Url { get; set; }
        public string Summary { get; set; }

        public virtual LmContactSpine Cs { get; set; }
        public virtual LmMailRun Lmr { get; set; }
        public virtual LmMailRunRecipient Lmrr { get; set; }
    }
}
