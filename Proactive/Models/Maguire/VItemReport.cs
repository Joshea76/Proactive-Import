using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VItemReport
    {
        public Guid ReId { get; set; }
        public string OwnerName { get; set; }
        public Guid? ReOwner { get; set; }
        public string ReType { get; set; }
        public string ReportType { get; set; }
        public string ReportArea { get; set; }
        public string ReQuery { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? SystemReport { get; set; }
        public bool? NotSrs { get; set; }
        public bool? NotLegacy { get; set; }
        public Guid? AcoId { get; set; }
        public Guid? ReIdStandardnull { get; set; }
        public Guid? ReIdValidChart { get; set; }
        public string AcGroup { get; set; }
        public Guid? UsgId { get; set; }
        public string AccessOptionName { get; set; }
        public string AccessOptionType { get; set; }
    }
}
