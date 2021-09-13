using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class IntegrationsModule
    {
        public Guid SimId { get; set; }
        public Guid SiId { get; set; }
        public Guid SimtId { get; set; }
        public string AlertFilename { get; set; }
        public byte? RunFrequencyType { get; set; }
        public int? RunFrequencyValue { get; set; }
        public byte? RetrievalPeriodType { get; set; }
        public int? RetrievalPeriodValue { get; set; }
        public bool Enabled { get; set; }
        public string DropSyncFieldName { get; set; }
        public bool DisabledByUpgrade { get; set; }

        public virtual Integration Si { get; set; }
    }
}
