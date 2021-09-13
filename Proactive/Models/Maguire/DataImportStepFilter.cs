using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DataImportStepFilter
    {
        public int Id { get; set; }
        public int StepId { get; set; }
        public byte DataType { get; set; }
        public bool Nullable { get; set; }
        public string OutputName { get; set; }
        public byte FilterType { get; set; }
        public string FilterValue { get; set; }
        public string DateTimeFormat { get; set; }

        public virtual DataImportStep Step { get; set; }
    }
}
