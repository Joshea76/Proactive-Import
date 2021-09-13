using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignListField
    {
        public Guid DfdId { get; set; }
        public Guid DltId { get; set; }
        public bool Selectable { get; set; }
        public bool? IsDefaultHorizontalField { get; set; }
        public bool? IsDefaultVerticalField { get; set; }

        public virtual DesignField Dfd { get; set; }
        public virtual DesignList Dlt { get; set; }
    }
}
