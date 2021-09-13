using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class UsaDate
    {
        public Guid UsaDateId { get; set; }

        public virtual UsersAppointment UsaDateNavigation { get; set; }
    }
}
