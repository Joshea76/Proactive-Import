using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Session
    {
        public Session()
        {
            SessionItems = new HashSet<SessionItem>();
        }

        public Guid SesId { get; set; }
        public Guid? SesiIdRoot { get; set; }
        public Guid UsId { get; set; }
        public string Label { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastActive { get; set; }
        public bool Hidden { get; set; }

        public virtual SessionItem SesiIdRootNavigation { get; set; }
        public virtual ICollection<SessionItem> SessionItems { get; set; }
    }
}
