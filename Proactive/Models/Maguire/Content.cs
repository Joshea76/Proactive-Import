using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Content
    {
        public Guid ContentsId { get; set; }
        public string ContentsName { get; set; }
        public Guid ColumnLayoutId { get; set; }
    }
}
