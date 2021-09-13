using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignEntity
    {
        public Guid DetId { get; set; }
        public Guid DstId { get; set; }
        public Guid DltId { get; set; }
        public Guid DscId { get; set; }
        public string LabelPlural { get; set; }
        public string LabelSingle { get; set; }

        public virtual DesignList Dlt { get; set; }
        public virtual DesignScreen Dsc { get; set; }
        public virtual DesignSet Dst { get; set; }
    }
}
