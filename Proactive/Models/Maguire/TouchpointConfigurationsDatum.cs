using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class TouchpointConfigurationsDatum
    {
        public int TpdId { get; set; }
        public Guid? UsId { get; set; }
        public string Name { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }

        public virtual User Us { get; set; }
    }
}
