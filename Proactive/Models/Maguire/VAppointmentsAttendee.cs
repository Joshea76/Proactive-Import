using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VAppointmentsAttendee
    {
        public Guid UaaId { get; set; }
        public Guid UsaId { get; set; }
        public Guid? UsId { get; set; }
        public Guid? AccId { get; set; }
        public string Attendee { get; set; }
        public Guid? RefId { get; set; }
        public string RefEmailAddress { get; set; }
        public string Summary { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Jobtitle { get; set; }
        public string Mobile { get; set; }
        public string AttendeeObjType { get; set; }
        public string AttendeeStatus { get; set; }
        public string AttendeeType { get; set; }
        public string AcName { get; set; }
        public string AccName { get; set; }
        public string AttendeeTeam { get; set; }
        public Guid? UsgId { get; set; }
        public Guid? AcId { get; set; }
        public string Subject { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string Location { get; set; }
        public string ParentType { get; set; }
        public bool? GoneFromOutlook { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public Guid? UsIdSales { get; set; }
        public Guid? UsIdSupport { get; set; }
        public string AcGroup { get; set; }
        public short? UsaAccessLevel { get; set; }
        public Guid? UsaUsId { get; set; }
        public Guid? SecurityId { get; set; }
        public string SecurityGroup { get; set; }
        public string SecurityObject { get; set; }
        public Guid? SecurityOwner { get; set; }
    }
}
