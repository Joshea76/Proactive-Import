using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VDropsOptionsActive
    {
        public Guid? DrId { get; set; }
        public Guid DroId { get; set; }
        public bool DroDeleted { get; set; }
        public int? DroOrder { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public string State { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string Hlight { get; set; }
        public Guid? PaId { get; set; }
        public string ExternalId { get; set; }
        public string DrSummary { get; set; }
    }
}
