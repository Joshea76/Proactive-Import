using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class GvvGetTimeObjectsByParentId
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
    }
}
