using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class UsersAppointmentsAttendee
    {
        public Guid UaaId { get; set; }
        public Guid UsaId { get; set; }
        public string Attendee { get; set; }
        public string AttendeeType { get; set; }
        public string AttendeeStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Guid? AccId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Guid? UsId { get; set; }
        public string ExternalId { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public bool? UaaDeleted { get; set; }
    }
}
