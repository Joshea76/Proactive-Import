using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class ComponentEditRole
    {
        public Guid ComId { get; set; }
        public Guid RoleId { get; set; }

        public virtual Role Role { get; set; }
    }
}
