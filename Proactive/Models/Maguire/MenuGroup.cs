using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MenuGroup
    {
        public Guid MgrpId { get; set; }
        public Guid UsId { get; set; }
        public Guid? UsgId { get; set; }
        public int AccessRights { get; set; }
        public string Icon { get; set; }
    }
}
