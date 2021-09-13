using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VTouchPointScore
    {
        public Guid? TpObjId { get; set; }
        public int? TpCsId { get; set; }
        public int TpScore { get; set; }
        public DateTime? TpDate { get; set; }
        public int TpMaxScore { get; set; }
    }
}
