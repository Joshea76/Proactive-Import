using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SystemLabel
    {
        public Guid LangId { get; set; }
        public Guid LabelId { get; set; }
        public string Label { get; set; }
        public DateTime LastUpdated { get; set; }
        public Guid SlId { get; set; }

        public virtual SystemLabelDescription LabelNavigation { get; set; }
        public virtual Language Lang { get; set; }
    }
}
