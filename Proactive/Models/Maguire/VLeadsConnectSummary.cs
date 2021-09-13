using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VLeadsConnectSummary
    {
        public Guid LmrId { get; set; }
        public Guid? LmrIdNullable { get; set; }
        public string Summary { get; set; }
        public string ListName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ListLayoutname { get; set; }
        public string ListLayoutnameNullable { get; set; }
        public string GvConnectUploadStatus { get; set; }
        public int? Uploaded { get; set; }
        public int? Sent { get; set; }
        public int? Read { get; set; }
        public int? Clicked { get; set; }
        public int? UnsubbedThis { get; set; }
        public int? UnsubbedAll { get; set; }
        public int? Replied { get; set; }
        public int? Forwarded { get; set; }
        public int? Bounced { get; set; }
        public string MailRunTypeName { get; set; }
        public string LmrDeleted { get; set; }
    }
}
