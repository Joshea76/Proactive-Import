using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MenuGroupsSetting
    {
        public Guid MgrpsId { get; set; }
        public Guid MgrpId { get; set; }
        public Guid UsId { get; set; }
        public int Order { get; set; }
        public bool Hidden { get; set; }
    }
}
