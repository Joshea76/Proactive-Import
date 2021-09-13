using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class LmUpdateImportMapping
    {
        public int UimId { get; set; }
        public bool Include { get; set; }
        public int ImportId { get; set; }
        public int? LeadsImportMapping { get; set; }
        public int? FileFieldOrd { get; set; }
        public bool MatchKey { get; set; }
        public bool ControlColumn { get; set; }

        public virtual LmImport Import { get; set; }
    }
}
