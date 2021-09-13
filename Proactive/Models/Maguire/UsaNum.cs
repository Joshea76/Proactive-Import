using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class UsaNum
    {
        public Guid UsaNumId { get; set; }

        public virtual UsersAppointment UsaNumNavigation { get; set; }
    }
}
