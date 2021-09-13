using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VAppointmentSyncList
    {
        public Guid UsaId { get; set; }
        public string AccountName { get; set; }
        public string Subject { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public DateTime? SyncUpdatedDate { get; set; }
        public string ParentType { get; set; }
        public string Username { get; set; }
    }
}
