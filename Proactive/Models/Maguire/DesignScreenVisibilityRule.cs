using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignScreenVisibilityRule
    {
        public Guid ScreenComponentId { get; set; }
        public Guid LfdId { get; set; }
        public Guid DroId { get; set; }
    }
}
