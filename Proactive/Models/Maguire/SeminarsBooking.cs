using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SeminarsBooking
    {
        public SeminarsBooking()
        {
            Agreements = new HashSet<Agreement>();
            SeminarsBookingsAttendees = new HashSet<SeminarsBookingsAttendee>();
            SeminarsBookingsAttendeesSeminarsLinks = new HashSet<SeminarsBookingsAttendeesSeminarsLink>();
            SeminarsBookingsProducts = new HashSet<SeminarsBookingsProduct>();
            SeminarsSessionsAttendees = new HashSet<SeminarsSessionsAttendee>();
        }

        public Guid? SemId { get; set; }
        public Guid SembId { get; set; }
        public bool SembDeleted { get; set; }
        public Guid AcId { get; set; }
        public Guid? AccId { get; set; }
        public string Details { get; set; }
        public bool Confirmed { get; set; }
        public decimal Value { get; set; }
        public double NumberOfItems { get; set; }
        public decimal CostItems { get; set; }
        public double DiscountItems { get; set; }
        public decimal CostBooking { get; set; }
        public double DiscountAccount { get; set; }
        public decimal CostSub { get; set; }
        public decimal CostUpdatedSub { get; set; }
        public decimal CostVat { get; set; }
        public decimal CostTotal { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string SembUd1Text { get; set; }
        public string SembUd2Text { get; set; }
        public string SembUd3Text { get; set; }
        public string SembUd4Text { get; set; }
        public string SembUd5Text { get; set; }
        public string SembUd6Text { get; set; }
        public string SembUd7Text { get; set; }
        public string SembUd8Text { get; set; }
        public string SembUd9Text { get; set; }
        public string SembUd10Text { get; set; }
        public DateTime? SembUd1Date { get; set; }
        public DateTime? SembUd2Date { get; set; }
        public DateTime? SembUd3Date { get; set; }
        public DateTime? SembUd4Date { get; set; }
        public DateTime? SembUd5Date { get; set; }
        public DateTime? SembUd6Date { get; set; }
        public DateTime? SembUd7Date { get; set; }
        public DateTime? SembUd8Date { get; set; }
        public DateTime? SembUd9Date { get; set; }
        public DateTime? SembUd10Date { get; set; }
        public Guid? SembUd1Id { get; set; }
        public Guid? SembUd2Id { get; set; }
        public Guid? SembUd3Id { get; set; }
        public Guid? SembUd4Id { get; set; }
        public Guid? SembUd5Id { get; set; }
        public Guid? SembUd6Id { get; set; }
        public Guid? SembUd7Id { get; set; }
        public Guid? SembUd8Id { get; set; }
        public Guid? SembUd9Id { get; set; }
        public Guid? SembUd10Id { get; set; }
        public bool? SembUd1Bit { get; set; }
        public bool? SembUd2Bit { get; set; }
        public bool? SembUd3Bit { get; set; }
        public bool? SembUd4Bit { get; set; }
        public bool? SembUd5Bit { get; set; }
        public bool? SembUd6Bit { get; set; }
        public bool? SembUd7Bit { get; set; }
        public bool? SembUd8Bit { get; set; }
        public bool? SembUd9Bit { get; set; }
        public bool? SembUd10Bit { get; set; }
        public bool? SembUd11Bit { get; set; }
        public bool? SembUd12Bit { get; set; }
        public bool? SembUd13Bit { get; set; }
        public bool? SembUd14Bit { get; set; }
        public bool? SembUd15Bit { get; set; }
        public bool? SembUd16Bit { get; set; }
        public bool? SembUd17Bit { get; set; }
        public bool? SembUd18Bit { get; set; }
        public bool? SembUd19Bit { get; set; }
        public bool? SembUd20Bit { get; set; }
        public bool? SembUd21Bit { get; set; }
        public bool? SembUd22Bit { get; set; }
        public bool? SembUd23Bit { get; set; }
        public bool? SembUd24Bit { get; set; }
        public decimal? SembUd1Numeric { get; set; }
        public decimal? SembUd2Numeric { get; set; }
        public decimal? SembUd3Numeric { get; set; }
        public decimal? SembUd4Numeric { get; set; }
        public decimal? SembUd5Numeric { get; set; }
        public decimal? SembUd6Numeric { get; set; }
        public decimal? SembUd7Numeric { get; set; }
        public decimal? SembUd8Numeric { get; set; }
        public decimal? SembUd9Numeric { get; set; }
        public decimal? SembUd10Numeric { get; set; }
        public string Reference { get; set; }
        public int? ReferenceSeed { get; set; }
        public byte? SembState { get; set; }
        public Guid? CurIdPriceList { get; set; }
        public DateTime? ActualClose { get; set; }
        public DateTime? EstimatedClose { get; set; }
        public Guid? FneId { get; set; }
        public Guid? McaId { get; set; }
        public Guid? StgId { get; set; }
        public string ExternalEventbriteId { get; set; }
        public Guid? Owner { get; set; }
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }
        public decimal? OriginalClosedWonTotal { get; set; }
        public DateTime? OriginalClosedWonDate { get; set; }
        public Guid? CurId { get; set; }

        public virtual Account Ac { get; set; }
        public virtual AccountsContact Acc { get; set; }
        public virtual Currency Cur { get; set; }
        public virtual FinancialEntity Fne { get; set; }
        public virtual Seminar Sem { get; set; }
        public virtual SembBit SembBit { get; set; }
        public virtual SembNum SembNum { get; set; }
        public virtual SembTxt SembTxt { get; set; }
        public virtual SembUid SembUid { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
        public virtual ICollection<SeminarsBookingsAttendee> SeminarsBookingsAttendees { get; set; }
        public virtual ICollection<SeminarsBookingsAttendeesSeminarsLink> SeminarsBookingsAttendeesSeminarsLinks { get; set; }
        public virtual ICollection<SeminarsBookingsProduct> SeminarsBookingsProducts { get; set; }
        public virtual ICollection<SeminarsSessionsAttendee> SeminarsSessionsAttendees { get; set; }
    }
}
