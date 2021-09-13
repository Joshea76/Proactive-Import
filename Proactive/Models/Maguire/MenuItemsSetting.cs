using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MenuItemsSetting
    {
        public Guid MitmsId { get; set; }
        public Guid MitmId { get; set; }
        public int Order { get; set; }
        public bool Hidden { get; set; }
    }
}
