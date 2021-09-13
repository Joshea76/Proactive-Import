using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class ReportType
    {
        public ReportType()
        {
            Reports = new HashSet<Report>();
        }

        public Guid RetId { get; set; }
        public string Summary { get; set; }
        public bool? SystemReport { get; set; }

        public virtual ICollection<Report> Reports { get; set; }
    }
}
