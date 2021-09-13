using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class UsaUid
    {
        public Guid UsaUidId { get; set; }

        public virtual UsersAppointment UsaUidNavigation { get; set; }
    }
}
