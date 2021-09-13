using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Licence
    {
        public Guid LicId { get; set; }
        public string LicData { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
