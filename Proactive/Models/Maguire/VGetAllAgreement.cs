using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VGetAllAgreement
    {
        public Guid AgrId { get; set; }
        public Guid UsId { get; set; }
        public Guid ParentId { get; set; }
        public Guid? AcId { get; set; }
        public Guid? AccId { get; set; }
        public Guid? OpId { get; set; }
        public Guid? OpqId { get; set; }
        public Guid? ActId { get; set; }
        public Guid? UsaId { get; set; }
        public Guid? AcpId { get; set; }
        public Guid? PjId { get; set; }
        public Guid? SemId { get; set; }
        public Guid? SembId { get; set; }
        public Guid? SemsId { get; set; }
        public Guid? SembaId { get; set; }
        public Guid? SemsaId { get; set; }
        public string AgreementName { get; set; }
        public string AgreementDocumentName { get; set; }
        public string AgreementDocumentFolder { get; set; }
        public byte AgreementStatus { get; set; }
        public byte AgreementProvider { get; set; }
        public string ProviderId { get; set; }
        public string ProviderStatus { get; set; }
        public bool AgreementCancelled { get; set; }
        public DateTime? CancelledDate { get; set; }
        public string CancelledBy { get; set; }
        public string ProviderLink { get; set; }
        public Guid? DocfId { get; set; }
        public bool IsDownloaded { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Guid? SiId { get; set; }
        public bool IsPortalAgreement { get; set; }
        public Guid? ExternalSocId { get; set; }
        public string ParentType { get; set; }
        public string Name { get; set; }
        public Guid? SitId { get; set; }
    }
}
