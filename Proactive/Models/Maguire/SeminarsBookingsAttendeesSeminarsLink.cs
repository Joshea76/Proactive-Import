using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SeminarsBookingsAttendeesSeminarsLink
    {
        public Guid SemaId { get; set; }
        public Guid SemId { get; set; }
        public Guid SembId { get; set; }
        public Guid SembaId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Seminar Sem { get; set; }
        public virtual SeminarsBooking Semb { get; set; }
        public virtual SeminarsBookingsAttendee Semba { get; set; }
    }
}
