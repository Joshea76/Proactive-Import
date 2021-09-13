using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class TodoCustomSelectValue
    {
        public int TodoId { get; set; }
        public int SelectItemId { get; set; }

        public virtual TodoCustomSelectItem SelectItem { get; set; }
        public virtual Todo Todo { get; set; }
    }
}
