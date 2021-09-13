using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class GvvUserAccessOption
    {
        public Guid AcoId { get; set; }
        public string Summary { get; set; }
        public Guid UsId { get; set; }
        public bool AllowEdit { get; set; }
        public bool AllowDelete { get; set; }
        public bool IsAdminOption { get; set; }
        public Guid? LicenceType { get; set; }
    }
}
