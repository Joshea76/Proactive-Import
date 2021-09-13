using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class PrivacyLog
    {
        public Guid PrlId { get; set; }
        public Guid? PrlPrrId { get; set; }
        public Guid? ObjId { get; set; }
        public int? CsId { get; set; }
        public int? LcId { get; set; }
        public string EventType { get; set; }
        public DateTime? EventDate { get; set; }
        public string UserName { get; set; }
        public bool? Notification { get; set; }
        public DateTime? RemovalDate { get; set; }
        public string DropdownValue { get; set; }
        public bool? Completed { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string CompletedBy { get; set; }
        public Guid? PuId { get; set; }

        public virtual PrivacyRule PrlPrr { get; set; }
    }
}
