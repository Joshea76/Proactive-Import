using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class TouchpointScore
    {
        public int TpscId { get; set; }
        public Guid? ObjId { get; set; }
        public int? CsId { get; set; }
        public int Score { get; set; }
        public DateTime? LastTp { get; set; }
        public int HighestScore { get; set; }
    }
}
