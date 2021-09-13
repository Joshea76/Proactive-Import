using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SubKey
    {
        public Guid KId { get; set; }
        public string SubKeyName { get; set; }
        public string SubKeyValue { get; set; }
    }
}
