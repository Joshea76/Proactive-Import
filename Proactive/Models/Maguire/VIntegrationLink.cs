using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VIntegrationLink
    {
        public Guid IiId { get; set; }
        public Guid Id { get; set; }
        public Guid ObjId { get; set; }
        public string Gvobject { get; set; }
        public string Gvname { get; set; }
        public string IntegrationId { get; set; }
        public string IntegrationName { get; set; }
        public string IntegrationType { get; set; }
        public Guid? FneId { get; set; }
        public string FinancialEntity { get; set; }
        public bool Primary { get; set; }
        public bool Secondary { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
