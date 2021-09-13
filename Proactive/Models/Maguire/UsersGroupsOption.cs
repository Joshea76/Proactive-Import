using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class UsersGroupsOption
    {
        public Guid GroId { get; set; }
        public Guid UsgId { get; set; }
        public Guid AcoId { get; set; }
        public bool AllowEdit { get; set; }
        public bool AllowDelete { get; set; }

        public virtual AccessOption Aco { get; set; }
        public virtual UsersGroup Usg { get; set; }
    }
}
