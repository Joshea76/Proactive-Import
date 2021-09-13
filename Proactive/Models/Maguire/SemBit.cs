using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SemBit
    {
        public Guid SemBitId { get; set; }

        public virtual Seminar SemBitNavigation { get; set; }
    }
}
