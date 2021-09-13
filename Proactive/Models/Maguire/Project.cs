using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Project
    {
        public Project()
        {
            Agreements = new HashSet<Agreement>();
            TimeUnitsRecords = new HashSet<TimeUnitsRecord>();
        }

        public Guid? AcId { get; set; }
        public Guid? AccId { get; set; }
        public Guid? Owner { get; set; }
        public Guid PjId { get; set; }
        public bool PjDeleted { get; set; }
        public Guid? PjFlag { get; set; }
        public decimal? Value { get; set; }
        public Guid? Stage { get; set; }
        public Guid? NextAction { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string PjUd1Text { get; set; }
        public string PjUd2Text { get; set; }
        public string PjUd3Text { get; set; }
        public string PjUd4Text { get; set; }
        public string PjUd5Text { get; set; }
        public string PjUd6Text { get; set; }
        public string PjUd7Text { get; set; }
        public string PjUd8Text { get; set; }
        public string PjUd9Text { get; set; }
        public string PjUd10Text { get; set; }
        public DateTime? PjUd1Date { get; set; }
        public DateTime? PjUd2Date { get; set; }
        public DateTime? PjUd3Date { get; set; }
        public DateTime? PjUd4Date { get; set; }
        public DateTime? PjUd5Date { get; set; }
        public DateTime? PjUd6Date { get; set; }
        public DateTime? PjUd7Date { get; set; }
        public DateTime? PjUd8Date { get; set; }
        public DateTime? PjUd9Date { get; set; }
        public DateTime? PjUd10Date { get; set; }
        public Guid? PjUd1Id { get; set; }
        public Guid? PjUd2Id { get; set; }
        public Guid? PjUd3Id { get; set; }
        public Guid? PjUd4Id { get; set; }
        public Guid? PjUd5Id { get; set; }
        public Guid? PjUd6Id { get; set; }
        public Guid? PjUd7Id { get; set; }
        public Guid? PjUd8Id { get; set; }
        public Guid? PjUd9Id { get; set; }
        public Guid? PjUd10Id { get; set; }
        public bool? PjUd1Bit { get; set; }
        public bool? PjUd2Bit { get; set; }
        public bool? PjUd3Bit { get; set; }
        public bool? PjUd4Bit { get; set; }
        public bool? PjUd5Bit { get; set; }
        public bool? PjUd6Bit { get; set; }
        public bool? PjUd7Bit { get; set; }
        public bool? PjUd8Bit { get; set; }
        public bool? PjUd9Bit { get; set; }
        public bool? PjUd10Bit { get; set; }
        public Guid? OpId { get; set; }
        public decimal? PjUd1Numeric { get; set; }
        public decimal? PjUd2Numeric { get; set; }
        public decimal? PjUd3Numeric { get; set; }
        public decimal? PjUd4Numeric { get; set; }
        public decimal? PjUd5Numeric { get; set; }
        public decimal? PjUd6Numeric { get; set; }
        public decimal? PjUd7Numeric { get; set; }
        public decimal? PjUd8Numeric { get; set; }
        public decimal? PjUd9Numeric { get; set; }
        public decimal? PjUd10Numeric { get; set; }
        public string PjExternal { get; set; }
        public Guid? PjImport { get; set; }
        public string Reference { get; set; }
        public bool? PjUd11Bit { get; set; }
        public bool? PjUd12Bit { get; set; }
        public bool? PjUd13Bit { get; set; }
        public bool? PjUd14Bit { get; set; }
        public bool? PjUd15Bit { get; set; }
        public bool? PjUd16Bit { get; set; }
        public bool? PjUd17Bit { get; set; }
        public bool? PjUd18Bit { get; set; }
        public bool? PjUd19Bit { get; set; }
        public bool? PjUd20Bit { get; set; }
        public bool? PjUd21Bit { get; set; }
        public bool? PjUd22Bit { get; set; }
        public bool? PjUd23Bit { get; set; }
        public bool? PjUd24Bit { get; set; }
        public Guid? SgId { get; set; }
        public int ShortCode { get; set; }
        public int EstimatedUnits { get; set; }
        public int EstimatedTime { get; set; }
        public int ActualUnits { get; set; }
        public int ActualTime { get; set; }
        public string ShortCodePrefix { get; set; }
        public Guid? SitId { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual Account Ac { get; set; }
        public virtual AccountsContact Acc { get; set; }
        public virtual User OwnerNavigation { get; set; }
        public virtual Site Sit { get; set; }
        public virtual PjBit PjBit { get; set; }
        public virtual PjDate PjDate { get; set; }
        public virtual PjNum PjNum { get; set; }
        public virtual PjTxt PjTxt { get; set; }
        public virtual PjUid PjUid { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
        public virtual ICollection<TimeUnitsRecord> TimeUnitsRecords { get; set; }
    }
}
