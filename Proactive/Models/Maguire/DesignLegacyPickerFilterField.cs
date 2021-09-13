using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignLegacyPickerFilterField
    {
        public Guid LfdIdPicker { get; set; }
        public Guid LfdIdFilterSource { get; set; }
        public Guid LfdIdFilterTarget { get; set; }
        public bool? AllowNulls { get; set; }
        public bool? FilterSourceIsItemid { get; set; }
        public bool? IsButtonLink { get; set; }
        public bool OnlyAppliesForNewScreen { get; set; }
    }
}
