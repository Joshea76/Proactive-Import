using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VwexTimeSheet
    {
        public Guid TsId { get; set; }
        public Guid? ObjId { get; set; }
        public string ActName { get; set; }
        public Guid? ActId { get; set; }
        public string AcName { get; set; }
        public Guid AcId { get; set; }
        public string UsName { get; set; }
        public Guid UsId { get; set; }
        public string OpName { get; set; }
        public Guid? OpId { get; set; }
        public string PjName { get; set; }
        public Guid? PjId { get; set; }
        public string ParentType { get; set; }
        public string ActivityType { get; set; }
        public string WorkType { get; set; }
        public string Summary { get; set; }
        public bool? TsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public decimal? Timespent { get; set; }
        public DateTime? DateOfWork { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Mileage { get; set; }
        public string Ud1Text { get; set; }
        public string Ud2Text { get; set; }
        public string Ud3Text { get; set; }
        public string Ud4Text { get; set; }
        public string Ud5Text { get; set; }
        public string Ud6Text { get; set; }
        public string Ud7Text { get; set; }
        public string Ud8Text { get; set; }
        public string Ud9Text { get; set; }
        public string Ud10Text { get; set; }
        public DateTime? Ud1Date { get; set; }
        public DateTime? Ud2Date { get; set; }
        public DateTime? Ud3Date { get; set; }
        public DateTime? Ud4Date { get; set; }
        public DateTime? Ud5Date { get; set; }
        public DateTime? Ud6Date { get; set; }
        public DateTime? Ud7Date { get; set; }
        public DateTime? Ud8Date { get; set; }
        public DateTime? Ud9Date { get; set; }
        public DateTime? Ud10Date { get; set; }
        public bool? Ud1Bit { get; set; }
        public bool? Ud2Bit { get; set; }
        public bool? Ud3Bit { get; set; }
        public bool? Ud4Bit { get; set; }
        public bool? Ud5Bit { get; set; }
        public bool? Ud6Bit { get; set; }
        public bool? Ud7Bit { get; set; }
        public bool? Ud8Bit { get; set; }
        public bool? Ud9Bit { get; set; }
        public bool? Ud10Bit { get; set; }
        public decimal? Ud1Numeric { get; set; }
        public decimal? Ud2Numeric { get; set; }
        public decimal? Ud3Numeric { get; set; }
        public decimal? Ud4Numeric { get; set; }
        public decimal? Ud5Numeric { get; set; }
        public decimal? Ud6Numeric { get; set; }
        public decimal? Ud7Numeric { get; set; }
        public decimal? Ud8Numeric { get; set; }
        public decimal? Ud9Numeric { get; set; }
        public decimal? Ud10Numeric { get; set; }
        public Guid? Ud1Id { get; set; }
        public Guid? Ud2Id { get; set; }
        public Guid? Ud3Id { get; set; }
        public Guid? Ud4Id { get; set; }
        public Guid? Ud5Id { get; set; }
        public Guid? Ud6Id { get; set; }
        public Guid? Ud7Id { get; set; }
        public Guid? Ud8Id { get; set; }
        public Guid? Ud9Id { get; set; }
        public Guid? Ud10Id { get; set; }
        public decimal? Days { get; set; }
        public string Team { get; set; }
        public string TsUd1Id { get; set; }
        public string TsUd2Id { get; set; }
        public string TsUd3Id { get; set; }
        public string TsUd4Id { get; set; }
        public string TsUd5Id { get; set; }
        public string TsUd6Id { get; set; }
        public string TsUd7Id { get; set; }
        public string TsUd8Id { get; set; }
        public string TsUd9Id { get; set; }
        public string TsUd10Id { get; set; }
        public string SupportType { get; set; }
        public string SupportPriority { get; set; }
        public string ShortCode { get; set; }
    }
}
