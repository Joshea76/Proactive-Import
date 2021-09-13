using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VIntegrationsList
    {
        public Guid? SiId { get; set; }
        public Guid? SitId { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? Enabled { get; set; }
        public string InstalledVersion { get; set; }
        public int? IsUpdating { get; set; }
        public string IntegrationVersion { get; set; }
        public bool? DisabledByUpgrade { get; set; }
        public int? IntegrationType { get; set; }
    }
}
