using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DataImportSourceMapping
    {
        public int Id { get; set; }
        public int SourceId { get; set; }
        public string ColumnName { get; set; }
        public int? ColumnNumber { get; set; }
        public byte DataType { get; set; }
        public string DateTimeFormat { get; set; }
        public string OutputName { get; set; }
        public byte? TransformationType { get; set; }
        public int? TruncationLength { get; set; }
        public byte? FilterType { get; set; }
        public string FilterValue { get; set; }
        public bool? Required { get; set; }
        public bool? HasTransformation { get; set; }
        public bool? HasFilter { get; set; }

        public virtual DataImportJobSource Source { get; set; }
    }
}
