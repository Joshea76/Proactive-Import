using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class StandardIntegrationsBatchfeed
    {
        public Guid SibId { get; set; }
        public Guid? SiId { get; set; }
        public string GvObjecttype { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public bool Enabled { get; set; }
        public string AlertFilename { get; set; }
    }
}
