using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class UserRoleGroup
    {
        public Guid? UsId { get; set; }
        public Guid? AccId { get; set; }
        public Guid RgId { get; set; }
        public Guid SpaceId { get; set; }
    }
}
