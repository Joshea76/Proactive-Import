using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SemTxt
    {
        public Guid SemTxtId { get; set; }

        public virtual Seminar SemTxtNavigation { get; set; }
    }
}
