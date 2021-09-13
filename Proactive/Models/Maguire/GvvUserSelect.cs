using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class GvvUserSelect
    {
        public Guid UsId { get; set; }
        public string Username { get; set; }
        public bool? Admin { get; set; }
        public bool? AccessAdmin { get; set; }
        public string EmailAddress { get; set; }
        public Guid? DstId { get; set; }
        public Guid? CurId { get; set; }
        public Guid? LangId { get; set; }
        public string CultureCode { get; set; }
        public string TimeId { get; set; }
        public string Summary { get; set; }
        public string AddressLookupDetails { get; set; }
        public bool IsActionCentrePinned { get; set; }
        public Guid? AcoTeamId { get; set; }
        public bool IsMenuExpanded { get; set; }
        public bool HybridEnabled { get; set; }
        public int HybridDefaultMode { get; set; }
        public int LicenceType { get; set; }
        public bool AccessEnabled { get; set; }
        public bool? MappingEnabled { get; set; }
        public bool? EmailScanContacts { get; set; }
        public int? DocumentStorageView { get; set; }
        public byte CalendarView { get; set; }
        public byte CalendarPeriod { get; set; }
        public byte CalendarDuration { get; set; }
    }
}
