using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VNotesForScanner
    {
        public Guid NtId { get; set; }
        public Guid? ParentId { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public Guid? UsId { get; set; }
        public bool? NtDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public Guid? AcId { get; set; }
        public Guid? AccId { get; set; }
        public Guid? AcaId { get; set; }
        public Guid? AccaId { get; set; }
        public Guid? OpId { get; set; }
        public Guid? OpcId { get; set; }
        public Guid? OpqId { get; set; }
        public Guid? OpcqId { get; set; }
        public Guid? PjId { get; set; }
        public Guid? AcpId { get; set; }
        public Guid? OpaId { get; set; }
        public Guid? OpcaId { get; set; }
        public Guid? PjaId { get; set; }
        public string NtExternal { get; set; }
        public Guid? NtImport { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? ReminderDate { get; set; }
        public bool ReminderAlerted { get; set; }
        public bool? ShowOnPortal { get; set; }
        public bool? OutlookNote { get; set; }
        public string NoteType { get; set; }
        public Guid? UsaId { get; set; }
        public bool? Sticky { get; set; }
        public bool? Notice { get; set; }
        public bool? NtEmpty { get; set; }
        public Guid? SemId { get; set; }
        public Guid AcIdEmpty { get; set; }
        public string Owner { get; set; }
        public string OwnerEmail { get; set; }
        public string ParentSummary { get; set; }
        public string ParentType { get; set; }
        public string NoteTypeSummary { get; set; }
        public Guid AcoId { get; set; }
        public string AcName { get; set; }
        public string AcGroup { get; set; }
        public Guid? UsIdSales { get; set; }
        public string AcManagerName { get; set; }
        public Guid? UsIdSupport { get; set; }
        public int HasReminder { get; set; }
        public Guid? SecurityId { get; set; }
        public string SecurityGroup { get; set; }
        public string SecurityObject { get; set; }
        public Guid? SecurityOwner { get; set; }
        public int ReminderDue { get; set; }
        public string CreatorEmail { get; set; }
        public string AccName { get; set; }
    }
}
