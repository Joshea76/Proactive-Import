using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AccessOption1
    {
        public Guid AcoId { get; set; }
        public string Summary { get; set; }
        public string SingularLabel { get; set; }
        public string PluralLabel { get; set; }
        public Guid? LicenceType { get; set; }
        public bool IsAdminOption { get; set; }
    }
}
