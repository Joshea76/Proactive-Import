using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignLabel
    {
        public Guid DlId { get; set; }
        public Guid ObjId { get; set; }
        public Guid LangId { get; set; }
        public string Label { get; set; }
        public DateTime LastUpdated { get; set; }
        public string LabelPlural { get; set; }

        public virtual Language Lang { get; set; }
    }
}
