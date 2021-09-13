using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Report
    {
        public Report()
        {
            UsersReports = new HashSet<UsersReport>();
        }

        public Guid ReId { get; set; }
        public bool ReDeleted { get; set; }
        public Guid? ReOwner { get; set; }
        public Guid? ReType { get; set; }
        public string ReQuery { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public Guid? RetId { get; set; }
        public string ReportArea { get; set; }
        public bool? SystemReport { get; set; }
        public string Summaryref { get; set; }
        public string Summaryreftemp { get; set; }
        public string Layouthint { get; set; }
        public string Xmldef { get; set; }
        public bool? ValidChart { get; set; }
        public bool? NotSrs { get; set; }
        public bool? NotLegacy { get; set; }
        public string ObjectType { get; set; }
        public Guid? AcoId { get; set; }
        public bool? ItemReport { get; set; }
        public bool? Temp { get; set; }

        public virtual User ReOwnerNavigation { get; set; }
        public virtual AccountsGroup ReTypeNavigation { get; set; }
        public virtual ReportType Ret { get; set; }
        public virtual ICollection<UsersReport> UsersReports { get; set; }
    }
}
