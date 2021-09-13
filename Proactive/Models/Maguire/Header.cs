using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Header
    {
        public Guid HeaderId { get; set; }
        public string HeaderName { get; set; }
        public Guid ColumnLayoutId { get; set; }
    }
}
