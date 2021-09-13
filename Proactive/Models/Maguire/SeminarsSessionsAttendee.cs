using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SeminarsSessionsAttendee
    {
        public SeminarsSessionsAttendee()
        {
            Agreements = new HashSet<Agreement>();
            SeminarsBookingsProducts = new HashSet<SeminarsBookingsProduct>();
        }

        public Guid SemId { get; set; }
        public Guid SemsId { get; set; }
        public Guid SembId { get; set; }
        public Guid SembaId { get; set; }
        public Guid SemsaId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string ExternalEventbriteId { get; set; }

        public virtual Seminar Sem { get; set; }
        public virtual SeminarsBooking Semb { get; set; }
        public virtual SeminarsBookingsAttendee Semba { get; set; }
        public virtual SeminarsSession Sems { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
        public virtual ICollection<SeminarsBookingsProduct> SeminarsBookingsProducts { get; set; }
    }
}
