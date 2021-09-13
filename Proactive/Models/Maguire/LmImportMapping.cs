using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class LmImportMapping
    {
        public int PimId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }
        public string ObjectName { get; set; }
        public string ColumnName { get; set; }
        public string FileFieldName { get; set; }
        public int FileOrdinal { get; set; }
        public string GvTargetField { get; set; }
        public string DataType { get; set; }
        public int PiId { get; set; }
        public bool? Include { get; set; }
        public int DataTableOrd { get; set; }
        public string Label { get; set; }

        public virtual LmImport Pi { get; set; }
    }
}
