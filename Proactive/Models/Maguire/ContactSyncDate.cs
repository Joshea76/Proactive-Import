using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class ContactSyncDate
    {
        public Guid CsdId { get; set; }
        public Guid AccId { get; set; }
        public Guid UsId { get; set; }
        public DateTime SyncDate { get; set; }

        public virtual AccountsContact Acc { get; set; }
        public virtual User Us { get; set; }
    }
}
