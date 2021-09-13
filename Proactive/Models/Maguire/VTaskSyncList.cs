using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VTaskSyncList
    {
        public Guid UstId { get; set; }
        public string AccountName { get; set; }
        public Guid AcId { get; set; }
        public Guid ActId { get; set; }
        public string Activity { get; set; }
        public string Username { get; set; }
        public DateTime? SyncUpdatedDate { get; set; }
        public string Status { get; set; }
    }
}
