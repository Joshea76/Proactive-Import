using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class GvvUserTargetDefinition
    {
        public Guid TardId { get; set; }
        public string UserTargetName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
