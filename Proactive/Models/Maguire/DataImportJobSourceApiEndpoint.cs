using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DataImportJobSourceApiEndpoint
    {
        public int Id { get; set; }
        public int SourceId { get; set; }
        public int ApiId { get; set; }
        public string Endpoint { get; set; }
        public string JsonResultPath { get; set; }

        public virtual DataImportJobSourceApi Api { get; set; }
        public virtual DataImportJobSource Source { get; set; }
    }
}
