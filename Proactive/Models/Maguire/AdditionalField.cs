using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AdditionalField
    {
        public AdditionalField()
        {
            AdditionalFieldsConfigurations = new HashSet<AdditionalFieldsConfiguration>();
        }

        public Guid Id { get; set; }
        public Guid AreaId { get; set; }
        public string Name { get; set; }
        public bool IsEditable { get; set; }
        public int? Order { get; set; }

        public virtual ICollection<AdditionalFieldsConfiguration> AdditionalFieldsConfigurations { get; set; }
    }
}
