using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class StandardIntegration
    {
        public Guid SiId { get; set; }
        public Guid? SitId { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public bool Enabled { get; set; }
        public string BaseUri { get; set; }
    }
}
