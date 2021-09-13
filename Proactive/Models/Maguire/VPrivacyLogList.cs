using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VPrivacyLogList
    {
        public Guid PrlId { get; set; }
        public Guid? ObjId { get; set; }
        public int? CsId { get; set; }
        public DateTime? EventDate { get; set; }
        public string EventType { get; set; }
        public string UserName { get; set; }
        public string PurposeName { get; set; }
        public string LawfulBasis { get; set; }
        public string Duration { get; set; }
        public DateTime? RemovalDate { get; set; }
        public bool? Notification { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Active { get; set; }
    }
}
