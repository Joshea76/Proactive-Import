using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class TemplateProperty
    {
        public Guid TpId { get; set; }
        public Guid AreaId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
    }
}
