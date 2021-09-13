using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class OrgCustomSelectItem
    {
        public OrgCustomSelectItem()
        {
            OrgCustomSelectValues = new HashSet<OrgCustomSelectValue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int SelectId { get; set; }

        public virtual OrgCustomSelect Select { get; set; }
        public virtual ICollection<OrgCustomSelectValue> OrgCustomSelectValues { get; set; }
    }
}
