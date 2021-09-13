using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Footer
    {
        public Guid FooterId { get; set; }
        public string FooterName { get; set; }
        public Guid ColumnLayoutId { get; set; }
    }
}
