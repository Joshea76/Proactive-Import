using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SessionItem
    {
        public SessionItem()
        {
            Sessions = new HashSet<Session>();
        }

        public Guid SesiId { get; set; }
        public Guid SesId { get; set; }
        public string Label { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Hidden { get; set; }
        public string RequestData { get; set; }
        public byte RequestType { get; set; }
        public Guid? DesignId { get; set; }
        public Guid? ItemId { get; set; }

        public virtual Session Ses { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
