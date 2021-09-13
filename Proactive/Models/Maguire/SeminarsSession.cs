using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SeminarsSession
    {
        public SeminarsSession()
        {
            Agreements = new HashSet<Agreement>();
            SeminarsSessionsAttendees = new HashSet<SeminarsSessionsAttendee>();
            SeminarsSessionsProducts = new HashSet<SeminarsSessionsProduct>();
        }

        public Guid SemId { get; set; }
        public Guid SemsId { get; set; }
        public bool SemsDeleted { get; set; }
        public string Summary { get; set; }
        public string Location { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public string Details { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short Places { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string SemsUd1Text { get; set; }
        public string SemsUd2Text { get; set; }
        public string SemsUd3Text { get; set; }
        public string SemsUd4Text { get; set; }
        public string SemsUd5Text { get; set; }
        public string SemsUd6Text { get; set; }
        public string SemsUd7Text { get; set; }
        public string SemsUd8Text { get; set; }
        public string SemsUd9Text { get; set; }
        public string SemsUd10Text { get; set; }
        public DateTime? SemsUd1Date { get; set; }
        public DateTime? SemsUd2Date { get; set; }
        public DateTime? SemsUd3Date { get; set; }
        public DateTime? SemsUd4Date { get; set; }
        public DateTime? SemsUd5Date { get; set; }
        public DateTime? SemsUd6Date { get; set; }
        public DateTime? SemsUd7Date { get; set; }
        public DateTime? SemsUd8Date { get; set; }
        public DateTime? SemsUd9Date { get; set; }
        public DateTime? SemsUd10Date { get; set; }
        public Guid? SemsUd1Id { get; set; }
        public Guid? SemsUd2Id { get; set; }
        public Guid? SemsUd3Id { get; set; }
        public Guid? SemsUd4Id { get; set; }
        public Guid? SemsUd5Id { get; set; }
        public Guid? SemsUd6Id { get; set; }
        public Guid? SemsUd7Id { get; set; }
        public Guid? SemsUd8Id { get; set; }
        public Guid? SemsUd9Id { get; set; }
        public Guid? SemsUd10Id { get; set; }
        public bool? SemsUd1Bit { get; set; }
        public bool? SemsUd2Bit { get; set; }
        public bool? SemsUd3Bit { get; set; }
        public bool? SemsUd4Bit { get; set; }
        public bool? SemsUd5Bit { get; set; }
        public bool? SemsUd6Bit { get; set; }
        public bool? SemsUd7Bit { get; set; }
        public bool? SemsUd8Bit { get; set; }
        public bool? SemsUd9Bit { get; set; }
        public bool? SemsUd10Bit { get; set; }
        public bool? SemsUd11Bit { get; set; }
        public bool? SemsUd12Bit { get; set; }
        public bool? SemsUd13Bit { get; set; }
        public bool? SemsUd14Bit { get; set; }
        public bool? SemsUd15Bit { get; set; }
        public bool? SemsUd16Bit { get; set; }
        public bool? SemsUd17Bit { get; set; }
        public bool? SemsUd18Bit { get; set; }
        public bool? SemsUd19Bit { get; set; }
        public bool? SemsUd20Bit { get; set; }
        public bool? SemsUd21Bit { get; set; }
        public bool? SemsUd22Bit { get; set; }
        public bool? SemsUd23Bit { get; set; }
        public bool? SemsUd24Bit { get; set; }
        public decimal? SemsUd1Numeric { get; set; }
        public decimal? SemsUd2Numeric { get; set; }
        public decimal? SemsUd3Numeric { get; set; }
        public decimal? SemsUd4Numeric { get; set; }
        public decimal? SemsUd5Numeric { get; set; }
        public decimal? SemsUd6Numeric { get; set; }
        public decimal? SemsUd7Numeric { get; set; }
        public decimal? SemsUd8Numeric { get; set; }
        public decimal? SemsUd9Numeric { get; set; }
        public decimal? SemsUd10Numeric { get; set; }
        public string ExternalEventbriteId { get; set; }
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public Guid? SitId { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual Seminar Sem { get; set; }
        public virtual Site Sit { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
        public virtual ICollection<SeminarsSessionsAttendee> SeminarsSessionsAttendees { get; set; }
        public virtual ICollection<SeminarsSessionsProduct> SeminarsSessionsProducts { get; set; }
    }
}
