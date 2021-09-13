using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Site
    {
        public Site()
        {
            Activities = new HashSet<Activity>();
            MarketingCampaigns = new HashSet<MarketingCampaign>();
            Notes = new HashSet<Note>();
            Projects = new HashSet<Project>();
            Seminars = new HashSet<Seminar>();
            SeminarsSessions = new HashSet<SeminarsSession>();
        }

        public Guid SitId { get; set; }
        public Guid AcId { get; set; }
        public Guid? AccId { get; set; }
        public Guid? UsId { get; set; }
        public string Summary { get; set; }
        public string SitExternal { get; set; }
        public Guid? Type1 { get; set; }
        public string Phone1 { get; set; }
        public string Fax1 { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string WebSite1 { get; set; }
        public string TimeZone { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public bool SitDeleted { get; set; }
        public string SitUd1 { get; set; }
        public string SitUd2 { get; set; }
        public string SitUd3 { get; set; }
        public string SitUd4 { get; set; }
        public string SitUd5 { get; set; }
        public string SitUd6 { get; set; }
        public string SitUd7 { get; set; }
        public string SitUd8 { get; set; }
        public string SitUd9 { get; set; }
        public string SitUd10 { get; set; }
        public string SitUd11 { get; set; }
        public string SitUd12 { get; set; }
        public string SitUd13 { get; set; }
        public string SitUd14 { get; set; }
        public string SitUd15 { get; set; }
        public Guid? SitUd1Id { get; set; }
        public Guid? SitUd2Id { get; set; }
        public Guid? SitUd3Id { get; set; }
        public Guid? SitUd4Id { get; set; }
        public Guid? SitUd5Id { get; set; }
        public Guid? SitUd6Id { get; set; }
        public Guid? SitUd7Id { get; set; }
        public Guid? SitUd8Id { get; set; }
        public Guid? SitUd9Id { get; set; }
        public Guid? SitUd10Id { get; set; }
        public DateTime? SitUd1Date { get; set; }
        public DateTime? SitUd2Date { get; set; }
        public DateTime? SitUd3Date { get; set; }
        public DateTime? SitUd4Date { get; set; }
        public DateTime? SitUd5Date { get; set; }
        public DateTime? SitUd6Date { get; set; }
        public DateTime? SitUd7Date { get; set; }
        public DateTime? SitUd8Date { get; set; }
        public DateTime? SitUd9Date { get; set; }
        public DateTime? SitUd10Date { get; set; }
        public bool? SitUd1Bit { get; set; }
        public bool? SitUd2Bit { get; set; }
        public bool? SitUd3Bit { get; set; }
        public bool? SitUd4Bit { get; set; }
        public bool? SitUd5Bit { get; set; }
        public bool? SitUd6Bit { get; set; }
        public bool? SitUd7Bit { get; set; }
        public bool? SitUd8Bit { get; set; }
        public bool? SitUd9Bit { get; set; }
        public bool? SitUd10Bit { get; set; }
        public bool? SitUd11Bit { get; set; }
        public bool? SitUd12Bit { get; set; }
        public bool? SitUd13Bit { get; set; }
        public bool? SitUd14Bit { get; set; }
        public bool? SitUd15Bit { get; set; }
        public bool? SitUd16Bit { get; set; }
        public bool? SitUd17Bit { get; set; }
        public bool? SitUd18Bit { get; set; }
        public bool? SitUd19Bit { get; set; }
        public bool? SitUd20Bit { get; set; }
        public bool? SitUd21Bit { get; set; }
        public bool? SitUd22Bit { get; set; }
        public bool? SitUd23Bit { get; set; }
        public bool? SitUd24Bit { get; set; }
        public decimal? SitUd1Numeric { get; set; }
        public decimal? SitUd2Numeric { get; set; }
        public decimal? SitUd3Numeric { get; set; }
        public decimal? SitUd4Numeric { get; set; }
        public decimal? SitUd5Numeric { get; set; }
        public decimal? SitUd6Numeric { get; set; }
        public decimal? SitUd7Numeric { get; set; }
        public decimal? SitUd8Numeric { get; set; }
        public decimal? SitUd9Numeric { get; set; }
        public decimal? SitUd10Numeric { get; set; }
        public Guid? SgId { get; set; }
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public string Reference { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual Account Ac { get; set; }
        public virtual SitBit SitBit { get; set; }
        public virtual SitNum SitNum { get; set; }
        public virtual SitTxt SitTxt { get; set; }
        public virtual SitUid SitUid { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<MarketingCampaign> MarketingCampaigns { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Seminar> Seminars { get; set; }
        public virtual ICollection<SeminarsSession> SeminarsSessions { get; set; }
    }
}
