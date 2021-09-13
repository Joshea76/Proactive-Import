using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AcaMuidLink
    {
        public Guid AcaMuidId { get; set; }
        public Guid DrId { get; set; }
        public Guid DroId { get; set; }
    }
}
