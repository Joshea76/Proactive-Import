using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class LmCallLog
    {
        public Guid ClmId { get; set; }
        public int CsId { get; set; }
        public Guid UsId { get; set; }
        public string Number { get; set; }
        public bool? Incomming { get; set; }
        public DateTime CallDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int? Duration { get; set; }

        public virtual LmContactSpine Cs { get; set; }
        public virtual User Us { get; set; }
    }
}
