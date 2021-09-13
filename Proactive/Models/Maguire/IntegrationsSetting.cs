using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class IntegrationsSetting
    {
        public Guid SetId { get; set; }
        public Guid SiId { get; set; }
        public string Value { get; set; }

        public virtual Integration Si { get; set; }
    }
}
