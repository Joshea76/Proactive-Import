using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class JobsType1
    {
        public Guid JobTypeId { get; set; }
        public string Summary { get; set; }
        public string Action { get; set; }
    }
}
