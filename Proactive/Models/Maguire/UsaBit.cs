using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class UsaBit
    {
        public Guid UsaBitId { get; set; }

        public virtual UsersAppointment UsaBitNavigation { get; set; }
    }
}
