using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class ViewContactsList
    {
        public int ContactId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string NextThing { get; set; }
        public string Type { get; set; }
        public string UserId { get; set; }
        public int? Opportunities { get; set; }
        public int? Leads { get; set; }
        public string Lists { get; set; }
        public int? LastActivity { get; set; }
        public int? LastDomainActivity { get; set; }
        public int? LastToDo { get; set; }
        public int? LastContactNote { get; set; }
        public string BoughtProductIds { get; set; }
        public string Source { get; set; }
        public string TelNo { get; set; }
        public string TelNo2 { get; set; }
        public string City { get; set; }
        public string TextField1 { get; set; }
        public string TextField2 { get; set; }
        public string TextField3 { get; set; }
        public string TextField4 { get; set; }
        public string Industry { get; set; }
        public string OrgName { get; set; }
        public string SimpleOrgName { get; set; }
        public string Instagram { get; set; }
        public bool IsMarked { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public int? DaysSince { get; set; }
        public int? LastContactModification { get; set; }
    }
}
