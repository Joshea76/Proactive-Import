using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AddressLine
    {
        public Guid LegacyFieldId { get; set; }
        public Guid AddressGroupId { get; set; }
        public int AddressLineType { get; set; }

        public virtual AddressGroup AddressGroup { get; set; }
    }
}
