using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class UsersRecent
    {
        public Guid UsreId { get; set; }
        public Guid UsId { get; set; }
        public Guid RefId { get; set; }
        public Guid? AcId { get; set; }
        public string Summary { get; set; }
        public string ParentSummary { get; set; }
        public string Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Listfilter { get; set; }

        public virtual Account Ac { get; set; }
        public virtual User Us { get; set; }
    }
}
