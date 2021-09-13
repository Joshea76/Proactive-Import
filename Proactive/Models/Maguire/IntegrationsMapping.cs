using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class IntegrationsMapping
    {
        public Guid SimmId { get; set; }
        public Guid SimId { get; set; }
        public string GvField { get; set; }
        public string TpField { get; set; }
        public string GvType { get; set; }
        public string SubMapping { get; set; }
    }
}
