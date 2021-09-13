using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Hotfix
    {
        public Guid HotId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
