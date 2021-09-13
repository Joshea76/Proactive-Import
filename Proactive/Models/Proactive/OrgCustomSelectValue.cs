using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class OrgCustomSelectValue
    {
        public int OrgId { get; set; }
        public int SelectItemId { get; set; }

        public virtual Org Org { get; set; }
        public virtual OrgCustomSelectItem SelectItem { get; set; }
    }
}
