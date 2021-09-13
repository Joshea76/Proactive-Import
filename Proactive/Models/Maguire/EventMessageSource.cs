using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class EventMessageSource
    {
        public Guid Id { get; set; }
        public Guid SourceId { get; set; }
        public string Summary { get; set; }
    }
}
