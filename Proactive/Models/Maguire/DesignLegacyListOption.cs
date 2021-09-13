using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignLegacyListOption
    {
        public Guid DloId { get; set; }
        public Guid LegId { get; set; }
        public bool Selected { get; set; }
        public string ListOption { get; set; }
        public string FunctionName { get; set; }

        public virtual DesignLegacyFile Leg { get; set; }
    }
}
