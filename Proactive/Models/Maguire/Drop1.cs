using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Drop1
    {
        public Drop1()
        {
            DropsOption1s = new HashSet<DropsOption1>();
        }

        public Guid DrId { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public string Label { get; set; }
        public Guid? ParentId { get; set; }
        public string ExternalId { get; set; }
        public bool? DropOptionsAreScreenDesignable { get; set; }

        public virtual ICollection<DropsOption1> DropsOption1s { get; set; }
    }
}
