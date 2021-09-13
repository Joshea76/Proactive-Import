using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class EventInformationField
    {
        public Guid EvtInfoId { get; set; }
        public Guid LfdId { get; set; }
        public int Order { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
