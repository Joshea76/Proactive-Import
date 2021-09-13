using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VContactSyncList
    {
        public Guid CsdId { get; set; }
        public string Summary { get; set; }
        public string AccountName { get; set; }
        public string Username { get; set; }
        public DateTime SyncDate { get; set; }
    }
}
