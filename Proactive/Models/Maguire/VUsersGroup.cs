using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VUsersGroup
    {
        public Guid UsgId { get; set; }
        public Guid? UsgId1 { get; set; }
        public Guid? UsgId2 { get; set; }
        public int? UsgAccess { get; set; }
        public bool UsgDeleted { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string Ud1 { get; set; }
        public string Ud2 { get; set; }
        public string Ud3 { get; set; }
        public string Ud4 { get; set; }
        public string Ud5 { get; set; }
        public string Ud6 { get; set; }
        public string Ud7 { get; set; }
        public string Ud8 { get; set; }
        public string Ud9 { get; set; }
        public string Ud10 { get; set; }
        public string Ud11 { get; set; }
        public string Ud12 { get; set; }
        public string Ud13 { get; set; }
        public string Ud14 { get; set; }
        public string Ud15 { get; set; }
        public byte? ViewAllProjects { get; set; }
        public string Subdirectory { get; set; }
        public bool? Hidden { get; set; }
        public decimal MonthlySalesTarget { get; set; }
        public Guid? DstId { get; set; }
        public string ShortCode { get; set; }
    }
}
