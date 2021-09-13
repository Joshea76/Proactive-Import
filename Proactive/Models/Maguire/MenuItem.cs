using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MenuItem
    {
        public Guid MitmId { get; set; }
        public Guid MgrpId { get; set; }
        public Guid ReqId { get; set; }
        public Guid? TypeId { get; set; }
        public Guid UsId { get; set; }
        public Guid? UsgId { get; set; }
        public byte MenuItemType { get; set; }
        public int AccessRights { get; set; }
    }
}
