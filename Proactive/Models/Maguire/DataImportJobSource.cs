using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DataImportJobSource
    {
        public DataImportJobSource()
        {
            DataImportJobSourceApiEndpoints = new HashSet<DataImportJobSourceApiEndpoint>();
            DataImportSourceMappings = new HashSet<DataImportSourceMapping>();
            DataImportSteps = new HashSet<DataImportStep>();
        }

        public int Id { get; set; }
        public int JobId { get; set; }
        public int SourceType { get; set; }
        public string FileDirectory { get; set; }
        public string FilenamePattern { get; set; }
        public string DateFormat { get; set; }
        public byte? FileOrderByType { get; set; }
        public byte? SortDirection { get; set; }
        public bool? HasHeaderRow { get; set; }
        public bool? ColumnReferenceByPosition { get; set; }
        public string Separator { get; set; }
        public int RunOrder { get; set; }
        public string Encoding { get; set; }

        public virtual DataImportJob Job { get; set; }
        public virtual ICollection<DataImportJobSourceApiEndpoint> DataImportJobSourceApiEndpoints { get; set; }
        public virtual ICollection<DataImportSourceMapping> DataImportSourceMappings { get; set; }
        public virtual ICollection<DataImportStep> DataImportSteps { get; set; }
    }
}
