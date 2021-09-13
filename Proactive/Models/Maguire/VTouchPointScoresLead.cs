using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VTouchPointScoresLead
    {
        public int? TpCsId { get; set; }
        public int TpCsScore { get; set; }
        public DateTime? TpCsDate { get; set; }
        public int TpCsMaxScore { get; set; }
    }
}
