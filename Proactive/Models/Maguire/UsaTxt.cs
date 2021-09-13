using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class UsaTxt
    {
        public Guid UsaTxtId { get; set; }

        public virtual UsersAppointment UsaTxtNavigation { get; set; }
    }
}
