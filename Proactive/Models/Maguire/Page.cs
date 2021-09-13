using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Page
    {
        public Page()
        {
            PageRoles = new HashSet<PageRole>();
        }

        public Guid PageId { get; set; }
        public Guid AreaId { get; set; }
        public string PageName { get; set; }
        public string JsonPayload { get; set; }
        public bool Created { get; set; }
        public bool RequiresDeleting { get; set; }
        public int Order { get; set; }
        public int PageType { get; set; }
        public bool IsHidden { get; set; }
        public bool Deleted { get; set; }
        public bool IsAreaRedirect { get; set; }
        public Guid? ModuleId { get; set; }

        public virtual Area Area { get; set; }
        public virtual Module Module { get; set; }
        public virtual ICollection<PageRole> PageRoles { get; set; }
    }
}
