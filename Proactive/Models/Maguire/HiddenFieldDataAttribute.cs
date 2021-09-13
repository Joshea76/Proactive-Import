using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class HiddenFieldDataAttribute
    {
        public Guid HdId { get; set; }
        public Guid LfdId { get; set; }
        public string Attribute { get; set; }
    }
}
