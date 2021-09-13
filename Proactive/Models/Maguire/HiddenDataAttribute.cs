using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class HiddenDataAttribute
    {
        public Guid HdId { get; set; }
        public Guid ObjId { get; set; }
        public string Attribute { get; set; }
        public string Column { get; set; }
    }
}
