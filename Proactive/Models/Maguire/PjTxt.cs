using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class PjTxt
    {
        public Guid PjTxtId { get; set; }

        public virtual Project PjTxtNavigation { get; set; }
    }
}
