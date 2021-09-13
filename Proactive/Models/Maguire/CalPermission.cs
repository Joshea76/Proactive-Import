using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class CalPermission
    {
        public Guid UsId { get; set; }
        public Guid UsgId { get; set; }
        public bool? ThirdPartyRead { get; set; }
        public bool? CreateEdit { get; set; }
    }
}
