using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VBasePrivacyLogEntriesForInsert
    {
        public Guid PrlPrrId { get; set; }
        public string EventType { get; set; }
        public string PurposeName { get; set; }
        public string LawfulBasis { get; set; }
        public int? Duration { get; set; }
        public bool? Notification { get; set; }
        public Guid? DropdownValue { get; set; }
        public int PrrRuleTypeId { get; set; }
        public byte? RemovalDateMode { get; set; }
        public bool PrrActive { get; set; }
        public Guid? PuId { get; set; }
    }
}
