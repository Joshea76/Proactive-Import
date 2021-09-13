using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Agreement
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
        public Guid? SiId { get; set; }
        public bool IsPortalAgreement { get; set; }
        public Guid? ExternalSocId { get; set; }

        public virtual Account Ac { get; set; }
        public virtual AccountsContact Acc { get; set; }
        public virtual AccountsProfile Acp { get; set; }
        public virtual Activity Act { get; set; }
        public virtual Document Doc { get; set; }
        public virtual DocumentsFolder Docf { get; set; }
        public virtual Opportunity Op { get; set; }
        public virtual OpportunitiesQuote Opq { get; set; }
        public virtual Project Pj { get; set; }
        public virtual Seminar Sem { get; set; }
        public virtual SeminarsBooking Semb { get; set; }
        public virtual SeminarsBookingsAttendee Semba { get; set; }
        public virtual SeminarsSession Sems { get; set; }
        public virtual SeminarsSessionsAttendee Semsa { get; set; }
        public virtual Integration Si { get; set; }
        public virtual User Us { get; set; }
        public virtual UsersAppointment Usa { get; set; }
    }
}
