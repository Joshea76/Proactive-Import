using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Note
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
        public int ShortCode { get; set; }
        public bool? IsPhoneNote { get; set; }
        public string ShortCodePrefix { get; set; }
        public Guid? SitId { get; set; }
        public string PrefixedShortCode { get; set; }
        public bool? IsSecure { get; set; }

        public virtual Account Ac { get; set; }
        public virtual AccountsContact Acc { get; set; }
        public virtual Site Sit { get; set; }
        public virtual User Us { get; set; }
    }
}
