using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VAlert
    {
        public Guid AlId { get; set; }
        public Guid AtId { get; set; }
        public Guid? JobId { get; set; }
        public string Summary { get; set; }
        public string ParentType { get; set; }
        public string ParentSummary { get; set; }
        public Guid? ObjId { get; set; }
        public Guid? AcId { get; set; }
        public bool? AlDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DismissedBy { get; set; }
        public DateTime? DismissedDate { get; set; }
        public int? ActionOptions { get; set; }
        public Guid? UsId { get; set; }
        public Guid? UsgId { get; set; }
        public string EmailAddress { get; set; }
        public int? ActionType { get; set; }
        public int? AlertStatus { get; set; }
        public int? EmailType { get; set; }
        public string EmailBody { get; set; }
        public string EmailSubject { get; set; }
        public string SmtpFrom { get; set; }
        public DateTime DueDate { get; set; }
        public Guid? AlIdAck { get; set; }
        public Guid? AlIdDismiss { get; set; }
        public string ActionTypeDescription { get; set; }
        public string AlertStatusDescription { get; set; }
        public int Initial { get; set; }
        public string User { get; set; }
        public string UserGroup { get; set; }
        public string Dismiss { get; set; }
        public string Noteclose { get; set; }
        public string AcManager { get; set; }
        public string AcManagerEmail { get; set; }
        public string AcName { get; set; }
    }
}
