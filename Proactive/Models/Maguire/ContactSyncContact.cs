using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class ContactSyncContact
    {
        public int Id { get; set; }
        public Guid AccId { get; set; }
        public Guid UsId { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime? LastSyncedDateUtc { get; set; }
        public string ThirdpartyId { get; set; }
        public bool SyncedWithOffice365 { get; set; }
        public byte JobType { get; set; }

        public virtual AccountsContact Acc { get; set; }
        public virtual User Us { get; set; }
    }
}
