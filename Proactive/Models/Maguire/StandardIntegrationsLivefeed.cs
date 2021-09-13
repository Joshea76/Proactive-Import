using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class StandardIntegrationsLivefeed
    {
        public Guid SilId { get; set; }
        public Guid? SiId { get; set; }
        public Guid? SilTypeId { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public bool Enabled { get; set; }
    }
}
