using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class LabelImport
    {
        public Guid LliId { get; set; }
        public Guid LangId { get; set; }
        public Guid LabelId { get; set; }
        public int LabelType { get; set; }
        public string Label { get; set; }
        public int State { get; set; }
        public Guid UsId { get; set; }
        public Guid ImportFileId { get; set; }

        public virtual Language Lang { get; set; }
    }
}
