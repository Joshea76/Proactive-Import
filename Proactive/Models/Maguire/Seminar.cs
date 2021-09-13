using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Seminar
    {
        public Seminar()
        {
            Agreements = new HashSet<Agreement>();
            EventInformations = new HashSet<EventInformation>();
            SeminarsBookings = new HashSet<SeminarsBooking>();
            SeminarsBookingsAttendees = new HashSet<SeminarsBookingsAttendee>();
            SeminarsBookingsAttendeesSeminarsLinks = new HashSet<SeminarsBookingsAttendeesSeminarsLink>();
            SeminarsBookingsProducts = new HashSet<SeminarsBookingsProduct>();
            SeminarsProducts = new HashSet<SeminarsProduct>();
            SeminarsSessions = new HashSet<SeminarsSession>();
            SeminarsSessionsAttendees = new HashSet<SeminarsSessionsAttendee>();
            SeminarsSessionsProducts = new HashSet<SeminarsSessionsProduct>();
        }

        public Guid SemId { get; set; }
        public bool SemDeleted { get; set; }
        public Guid? CurId { get; set; }
        public Guid? Owner { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid? Stage { get; set; }
        public Guid? Type { get; set; }
        public decimal? Value { get; set; }
        public decimal? EarlyBirdDiscount { get; set; }
        public DateTime? EarlyBirdDate { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string SemUd1Text { get; set; }
        public string SemUd2Text { get; set; }
        public string SemUd3Text { get; set; }
        public string SemUd4Text { get; set; }
        public string SemUd5Text { get; set; }
        public string SemUd6Text { get; set; }
        public string SemUd7Text { get; set; }
        public string SemUd8Text { get; set; }
        public string SemUd9Text { get; set; }
        public string SemUd10Text { get; set; }
        public DateTime? SemUd1Date { get; set; }
        public DateTime? SemUd2Date { get; set; }
        public DateTime? SemUd3Date { get; set; }
        public DateTime? SemUd4Date { get; set; }
        public DateTime? SemUd5Date { get; set; }
        public DateTime? SemUd6Date { get; set; }
        public DateTime? SemUd7Date { get; set; }
        public DateTime? SemUd8Date { get; set; }
        public DateTime? SemUd9Date { get; set; }
        public DateTime? SemUd10Date { get; set; }
        public Guid? SemUd1Id { get; set; }
        public Guid? SemUd2Id { get; set; }
        public Guid? SemUd3Id { get; set; }
        public Guid? SemUd4Id { get; set; }
        public Guid? SemUd5Id { get; set; }
        public Guid? SemUd6Id { get; set; }
        public Guid? SemUd7Id { get; set; }
        public Guid? SemUd8Id { get; set; }
        public Guid? SemUd9Id { get; set; }
        public Guid? SemUd10Id { get; set; }
        public bool? SemUd1Bit { get; set; }
        public bool? SemUd2Bit { get; set; }
        public bool? SemUd3Bit { get; set; }
        public bool? SemUd4Bit { get; set; }
        public bool? SemUd5Bit { get; set; }
        public bool? SemUd6Bit { get; set; }
        public bool? SemUd7Bit { get; set; }
        public bool? SemUd8Bit { get; set; }
        public bool? SemUd9Bit { get; set; }
        public bool? SemUd10Bit { get; set; }
        public bool? SemUd11Bit { get; set; }
        public bool? SemUd12Bit { get; set; }
        public bool? SemUd13Bit { get; set; }
        public bool? SemUd14Bit { get; set; }
        public bool? SemUd15Bit { get; set; }
        public bool? SemUd16Bit { get; set; }
        public bool? SemUd17Bit { get; set; }
        public bool? SemUd18Bit { get; set; }
        public bool? SemUd19Bit { get; set; }
        public bool? SemUd20Bit { get; set; }
        public bool? SemUd21Bit { get; set; }
        public bool? SemUd22Bit { get; set; }
        public bool? SemUd23Bit { get; set; }
        public bool? SemUd24Bit { get; set; }
        public decimal? SemUd1Numeric { get; set; }
        public decimal? SemUd2Numeric { get; set; }
        public decimal? SemUd3Numeric { get; set; }
        public decimal? SemUd4Numeric { get; set; }
        public decimal? SemUd5Numeric { get; set; }
        public decimal? SemUd6Numeric { get; set; }
        public decimal? SemUd7Numeric { get; set; }
        public decimal? SemUd8Numeric { get; set; }
        public decimal? SemUd9Numeric { get; set; }
        public decimal? SemUd10Numeric { get; set; }
        public string SemExternal { get; set; }
        public Guid? SemImport { get; set; }
        public string Reference { get; set; }
        public int? ReferenceSeed { get; set; }
        public Guid? AcId { get; set; }
        public Guid? McaId { get; set; }
        public Guid? StgId { get; set; }
        public decimal? ValueWon { get; set; }
        public decimal? ValueLost { get; set; }
        public decimal? ValueConfirmed { get; set; }
        public string TimeZone { get; set; }
        public string ExternalEventbriteId { get; set; }
        public Guid? EventbriteAnonAttendeeAcId { get; set; }
        public decimal? ValueOpen { get; set; }
        public string Url { get; set; }
        public string SourceDetails { get; set; }
        public Guid? SgId { get; set; }
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public Guid? SitId { get; set; }
        public string PrefixedShortCode { get; set; }
        public short Places { get; set; }
        public int? LcId { get; set; }
        public decimal? Price { get; set; }

        public virtual Currency Cur { get; set; }
        public virtual LmListcontrol Lc { get; set; }
        public virtual Site Sit { get; set; }
        public virtual SemBit SemBit { get; set; }
        public virtual SemDate SemDate { get; set; }
        public virtual SemNum SemNum { get; set; }
        public virtual SemTxt SemTxt { get; set; }
        public virtual SemUid SemUid { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
        public virtual ICollection<EventInformation> EventInformations { get; set; }
        public virtual ICollection<SeminarsBooking> SeminarsBookings { get; set; }
        public virtual ICollection<SeminarsBookingsAttendee> SeminarsBookingsAttendees { get; set; }
        public virtual ICollection<SeminarsBookingsAttendeesSeminarsLink> SeminarsBookingsAttendeesSeminarsLinks { get; set; }
        public virtual ICollection<SeminarsBookingsProduct> SeminarsBookingsProducts { get; set; }
        public virtual ICollection<SeminarsProduct> SeminarsProducts { get; set; }
        public virtual ICollection<SeminarsSession> SeminarsSessions { get; set; }
        public virtual ICollection<SeminarsSessionsAttendee> SeminarsSessionsAttendees { get; set; }
        public virtual ICollection<SeminarsSessionsProduct> SeminarsSessionsProducts { get; set; }
    }
}
