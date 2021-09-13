using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignFieldGroupFieldLink
    {
        public Guid DfdId { get; set; }
        public Guid DsfgId { get; set; }
        public short? FieldGroupFieldOrdinal { get; set; }

        public virtual DesignField Dfd { get; set; }
        public virtual DesignScreenFieldGroup Dsfg { get; set; }
    }
}
