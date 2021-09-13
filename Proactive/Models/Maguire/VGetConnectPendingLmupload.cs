using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VGetConnectPendingLmupload
    {
        public Guid LmrId { get; set; }
        public string RecipientFilter { get; set; }
        public string Summary { get; set; }
        public Guid MailRunType { get; set; }
        public Guid Owner { get; set; }
    }
}
