using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class IntegrationId
    {
        public Guid IiId { get; set; }
        public Guid ObjId { get; set; }
        public string IntegrationName { get; set; }
        public string IntegrationType { get; set; }
        public string IntegrationId1 { get; set; }
        public bool? Secondary { get; set; }
        public Guid? FneId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IiDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? IiDeletedByObject { get; set; }

        public virtual FinancialEntity Fne { get; set; }
    }
}
