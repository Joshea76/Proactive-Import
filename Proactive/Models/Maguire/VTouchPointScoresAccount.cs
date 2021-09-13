using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VTouchPointScoresAccount
    {
        public Guid? TpAcId { get; set; }
        public int TpAcScore { get; set; }
        public DateTime? TpAcDate { get; set; }
        public int TpAcMaxScore { get; set; }
    }
}
