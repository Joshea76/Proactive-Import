using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DataImportStep
    {
        public DataImportStep()
        {
            DataImportStepFilters = new HashSet<DataImportStepFilter>();
            DataImportStepMappings = new HashSet<DataImportStepMapping>();
        }

        public int Id { get; set; }
        public int SourceId { get; set; }
        public string Name { get; set; }
        public byte StepType { get; set; }
        public byte OperationType { get; set; }
        public string ObjectName { get; set; }
        public byte MultipleLookupItemsFoundOperation { get; set; }
        public byte NoLookupItemsFoundOperation { get; set; }
        public bool IsExtension { get; set; }

        public virtual DataImportJobSource Source { get; set; }
        public virtual ICollection<DataImportStepFilter> DataImportStepFilters { get; set; }
        public virtual ICollection<DataImportStepMapping> DataImportStepMappings { get; set; }
    }
}
