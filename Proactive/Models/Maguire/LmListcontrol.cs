using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class LmListcontrol
    {
        public LmListcontrol()
        {
            ImportContactJobs = new HashSet<ImportContactJob>();
            LmMailRuns = new HashSet<LmMailRun>();
            Seminars = new HashSet<Seminar>();
        }

        public int LcId { get; set; }
        public Guid LlId { get; set; }
        public int? PiId { get; set; }
        public string Summary { get; set; }
        public int ListOpen { get; set; }
        public byte DedupeStatus { get; set; }
        public Guid UsId { get; set; }
        public string ListTablename { get; set; }
        public string ListLayoutname { get; set; }
        public string ListObjectname { get; set; }
        public string DedupePackage { get; set; }
        public byte? LeadAllocationMode { get; set; }
        public byte? UpgradeMode { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool LcDeleted { get; set; }
        public int? CTotal { get; set; }
        public int? CFailed { get; set; }
        public int? CSucceeded { get; set; }
        public int? CWorkingTotal { get; set; }
        public int? CPromoted { get; set; }
        public int? CClaimed { get; set; }
        public int? Version { get; set; }
        public Guid? LcListtype { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual LmImport Pi { get; set; }
        public virtual User Us { get; set; }
        public virtual ICollection<ImportContactJob> ImportContactJobs { get; set; }
        public virtual ICollection<LmMailRun> LmMailRuns { get; set; }
        public virtual ICollection<Seminar> Seminars { get; set; }
    }
}
