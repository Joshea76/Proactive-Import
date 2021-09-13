using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignMenuGroup
    {
        public DesignMenuGroup()
        {
            DesignMenuGroupItemOrders = new HashSet<DesignMenuGroupItemOrder>();
        }

        public Guid Id { get; set; }
        public int? GroupOrder { get; set; }
        public string GroupDescription { get; set; }
        public short? MenuType { get; set; }

        public virtual ICollection<DesignMenuGroupItemOrder> DesignMenuGroupItemOrders { get; set; }
    }
}
