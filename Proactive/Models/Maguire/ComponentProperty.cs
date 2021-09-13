using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class ComponentProperty
    {
        public Guid ComPropId { get; set; }
        public Guid ComId { get; set; }
        public Guid AreaId { get; set; }
        public int PropertyType { get; set; }
        public string Value { get; set; }
        public bool RequiresDeleting { get; set; }
        public bool Deleted { get; set; }
    }
}
