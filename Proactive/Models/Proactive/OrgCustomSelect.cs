using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class OrgCustomSelect
    {
        public OrgCustomSelect()
        {
            OrgCustomSelectItems = new HashSet<OrgCustomSelectItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public bool ShowInTable { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<OrgCustomSelectItem> OrgCustomSelectItems { get; set; }
    }
}
