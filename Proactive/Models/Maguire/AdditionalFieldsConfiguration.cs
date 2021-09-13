using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AdditionalFieldsConfiguration
    {
        public Guid Id { get; set; }
        public Guid FieldId { get; set; }
        public Guid AreaId { get; set; }
        public string Configuration { get; set; }

        public virtual Area Area { get; set; }
        public virtual AdditionalField Field { get; set; }
    }
}
