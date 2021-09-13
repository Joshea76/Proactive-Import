using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DataImportMessage
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int? JobId { get; set; }
        public int? SourceId { get; set; }
        public int? StepId { get; set; }
        public int? LineNumber { get; set; }
        public string Filename { get; set; }
        public string Description { get; set; }
    }
}
