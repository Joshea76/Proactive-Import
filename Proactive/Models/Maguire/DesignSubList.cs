using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignSubList
    {
        public Guid DltId { get; set; }
        public Guid DspsId { get; set; }

        public virtual DesignList Dlt { get; set; }
        public virtual DesignScreenPageSection Dsps { get; set; }
    }
}
