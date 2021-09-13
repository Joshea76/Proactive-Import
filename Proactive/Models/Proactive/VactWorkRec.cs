using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class VactWorkRec
    {
        public int VactWorkRecId { get; set; }
        public string VactivityName { get; set; }
        public string VactivityDescription { get; set; }
        public int VtimeWorkTaken { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
