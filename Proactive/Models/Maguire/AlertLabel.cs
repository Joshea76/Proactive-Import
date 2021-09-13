using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AlertLabel
    {
        public string AlertDefFilename { get; set; }
        public Guid LangId { get; set; }
        public Guid LabelId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Group { get; set; }
        public DateTime LastUpdated { get; set; }

        public virtual Language Lang { get; set; }
    }
}
