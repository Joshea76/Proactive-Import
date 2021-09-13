using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DropsOption1
    {
        public Guid DrId { get; set; }
        public Guid DroId { get; set; }
        public bool DroDeleted { get; set; }
        public int? DroOrder { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public string State { get; set; }
        public string Hlight { get; set; }
        public Guid? PaId { get; set; }
        public string ExternalId { get; set; }

        public virtual Drop1 Dr { get; set; }
    }
}
