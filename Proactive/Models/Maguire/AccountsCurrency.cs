using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AccountsCurrency
    {
        public Guid AcurId { get; set; }
        public Guid AcId { get; set; }
        public Guid CurId { get; set; }
        public bool IsDefault { get; set; }
    }
}
