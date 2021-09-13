using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class McMuidLink
    {
        public Guid McMuidId { get; set; }
        public Guid DrId { get; set; }
        public Guid DroId { get; set; }
    }
}
