using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class TouchpointHistory
    {
        public int HisId { get; set; }
        public Guid? ObjId { get; set; }
        public int? CsId { get; set; }
        public int Score { get; set; }
        public DateTime? LastTp { get; set; }
        public Guid? Ref { get; set; }
        public DateTime ScoreDate { get; set; }
    }
}
