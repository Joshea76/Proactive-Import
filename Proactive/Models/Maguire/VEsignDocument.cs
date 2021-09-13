using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VEsignDocument
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
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool AgrDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public Guid? DocId { get; set; }
        public string ProviderLink { get; set; }
        public bool IsDownloaded { get; set; }
        public Guid? DocfId { get; set; }
        public string Summary { get; set; }
        public string User { get; set; }
        public string AcName { get; set; }
        public string AccName { get; set; }
        public Guid? ParentOwnerId { get; set; }
        public string ParentOwner { get; set; }
        public string Path { get; set; }
        public string Status { get; set; }
        public string ParentSummary { get; set; }
        public string Type { get; set; }
        public Guid? SecurityId { get; set; }
        public string SecurityGroup { get; set; }
        public string SecurityObject { get; set; }
        public Guid? SecurityOwner { get; set; }
    }
}
