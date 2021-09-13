using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VLeadControlList
    {
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
        public int? LcIdOpen { get; set; }
        public string ListLayoutnameOpen { get; set; }
        public int Deduping { get; set; }
        public string DedupeStatusText { get; set; }
        public string UsName { get; set; }
        public string ViewRecords { get; set; }
        public string ManageList { get; set; }
        public string LcListtypeName { get; set; }
        public string ShortCode { get; set; }
    }
}
