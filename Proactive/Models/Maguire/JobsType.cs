using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class JobsType
    {
        public Guid JobTypeId { get; set; }
        public string Summary { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Action { get; set; }
    }
}
