using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VPhoneSystem
    {
        public Guid SetId { get; set; }
        public string Setting { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public bool? Selected { get; set; }
        public Guid? SetIdDelete { get; set; }
        public string PhoneType { get; set; }
        public int UserCount { get; set; }
        public int InUse { get; set; }
    }
}
