using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class GvvUserAccessOptionsLabelExport
    {
        public Guid AcoId { get; set; }
        public string Summary { get; set; }
        public string Label { get; set; }
        public string LabelPlural { get; set; }
        public Guid? LangId { get; set; }
    }
}
