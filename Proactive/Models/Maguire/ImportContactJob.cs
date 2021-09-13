using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class ImportContactJob
    {
        public Guid BatchId { get; set; }
        public long JobId { get; set; }
        public string ThirdpartyId { get; set; }
        public Guid? AcId { get; set; }
        public int? LcId { get; set; }
        public Guid UsId { get; set; }
        public bool Sync { get; set; }
        public byte Status { get; set; }
        public byte Attempts { get; set; }
        public DateTime CreatedDateUtc { get; set; }

        public virtual Account Ac { get; set; }
        public virtual LmListcontrol Lc { get; set; }
        public virtual User Us { get; set; }
    }
}
