using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class TimePeriod
    {
        public int TimId { get; set; }
        public string Summary { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public bool? IsPublic { get; set; }
        public Guid? UsrId { get; set; }
    }
}
