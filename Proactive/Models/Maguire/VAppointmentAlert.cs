using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VAppointmentAlert
    {
        public Guid UsaId { get; set; }
        public Guid? UsId { get; set; }
        public string Subject { get; set; }
        public DateTime? DateValue { get; set; }
    }
}
