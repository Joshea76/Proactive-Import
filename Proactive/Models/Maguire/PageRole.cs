using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class PageRole
    {
        public Guid SrId { get; set; }
        public Guid PageId { get; set; }
        public Guid RId { get; set; }

        public virtual Page Page { get; set; }
        public virtual Role RIdNavigation { get; set; }
    }
}
