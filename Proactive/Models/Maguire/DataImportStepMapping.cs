using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DataImportStepMapping
    {
        public int Id { get; set; }
        public int StepId { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
        public byte SourceType { get; set; }
        public bool IsIdMapping { get; set; }
        public bool IsInputMap { get; set; }
        public bool ExactMatch { get; set; }

        public virtual DataImportStep Step { get; set; }
    }
}
