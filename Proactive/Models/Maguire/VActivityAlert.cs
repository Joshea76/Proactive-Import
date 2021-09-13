using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VActivityAlert
    {
        public Guid ActId { get; set; }
        public Guid? UsId { get; set; }
        public string Summary { get; set; }
        public DateTime? DateValue { get; set; }
    }
}
