using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AddressGroup
    {
        public AddressGroup()
        {
            AddressLines = new HashSet<AddressLine>();
        }

        public Guid AddressGroupId { get; set; }
        public Guid? LinkedSiteLfdId { get; set; }

        public virtual ICollection<AddressLine> AddressLines { get; set; }
    }
}
