using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class EventInformation
    {
        public Guid SemId { get; set; }
        public Guid EvtInfoId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Seminar Sem { get; set; }
    }
}
