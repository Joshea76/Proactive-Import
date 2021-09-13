using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Touchpoint
    {
        public Touchpoint()
        {
            TouchpointLinks = new HashSet<TouchpointLink>();
        }

        public int TpId { get; set; }
        public int TpcId { get; set; }
        public Guid? SocId { get; set; }
        public Guid TrackingId { get; set; }
        public string ExternalId { get; set; }
        public Guid? SessionId { get; set; }
        public bool RootTp { get; set; }
        public bool? HasChildren { get; set; }
        public Guid? McaId { get; set; }
        public Guid? McsrId { get; set; }
        public Guid? StgId { get; set; }
        public string SocialMsgId { get; set; }
        public int? Score { get; set; }
        public int? SessionScore { get; set; }
        public string Action { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public bool TpDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactJobtitle { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Postcode { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string Source { get; set; }
        public string Industry { get; set; }
        public int DurationSeconds { get; set; }
        public string ItemUrl { get; set; }
        public string ImageUrl { get; set; }
        public string ProfileUrl { get; set; }
        public string ProfileId { get; set; }
        public string PrivateId { get; set; }
        public Guid? UsId { get; set; }
        public string TpUd1 { get; set; }
        public string TpUd2 { get; set; }
        public string TpUd3 { get; set; }
        public string TpUd4 { get; set; }
        public string TpUd5 { get; set; }
        public string TpUd6 { get; set; }
        public string TpUd7 { get; set; }
        public string TpUd8 { get; set; }
        public string TpUd9 { get; set; }
        public string TpUd10 { get; set; }
        public DateTime? TpUd1Date { get; set; }
        public DateTime? TpUd2Date { get; set; }
        public DateTime? TpUd3Date { get; set; }
        public DateTime? TpUd4Date { get; set; }
        public DateTime? TpUd5Date { get; set; }
        public DateTime? TpUd6Date { get; set; }
        public DateTime? TpUd7Date { get; set; }
        public DateTime? TpUd8Date { get; set; }
        public DateTime? TpUd9Date { get; set; }
        public DateTime? TpUd10Date { get; set; }
        public decimal? TpUd1Numeric { get; set; }
        public decimal? TpUd2Numeric { get; set; }
        public decimal? TpUd3Numeric { get; set; }
        public decimal? TpUd4Numeric { get; set; }
        public decimal? TpUd5Numeric { get; set; }
        public decimal? TpUd6Numeric { get; set; }
        public decimal? TpUd7Numeric { get; set; }
        public decimal? TpUd8Numeric { get; set; }
        public decimal? TpUd9Numeric { get; set; }
        public decimal? TpUd10Numeric { get; set; }
        public bool? TpUd1Bit { get; set; }
        public bool? TpUd2Bit { get; set; }
        public bool? TpUd3Bit { get; set; }
        public bool? TpUd4Bit { get; set; }
        public bool? TpUd5Bit { get; set; }
        public bool? TpUd6Bit { get; set; }
        public bool? TpUd7Bit { get; set; }
        public bool? TpUd8Bit { get; set; }
        public bool? TpUd9Bit { get; set; }
        public bool? TpUd10Bit { get; set; }
        public string TpGeneric1 { get; set; }
        public string TpGeneric2 { get; set; }
        public string TpGeneric3 { get; set; }
        public string TpGeneric4 { get; set; }
        public string TpGeneric5 { get; set; }
        public string TpGeneric6 { get; set; }
        public string TpGeneric7 { get; set; }
        public string TpGeneric8 { get; set; }
        public string TpGeneric9 { get; set; }
        public string TpGeneric10 { get; set; }
        public Guid? TpUd1Id { get; set; }
        public Guid? TpUd2Id { get; set; }
        public Guid? TpUd3Id { get; set; }
        public Guid? TpUd4Id { get; set; }
        public Guid? TpUd5Id { get; set; }
        public Guid? TpUd6Id { get; set; }
        public Guid? TpUd7Id { get; set; }
        public Guid? TpUd8Id { get; set; }
        public Guid? TpUd9Id { get; set; }
        public Guid? TpUd10Id { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Domain { get; set; }
        public string Website { get; set; }
        public string Keywords { get; set; }
        public bool? ScoreThis { get; set; }
        public int? GeoLat { get; set; }
        public int? GeoLong { get; set; }
        public string CompanyIndustrySic { get; set; }
        public string CompanyNoEmployees { get; set; }
        public string CompanyTurnover { get; set; }
        public string CompanyFounded { get; set; }
        public string CompanyReg { get; set; }

        public virtual MarketingCampaign Mca { get; set; }
        public virtual MarketingCampaignStageRun Mcsr { get; set; }
        public virtual MarketingCampaignStage Stg { get; set; }
        public virtual TouchpointConfiguration Tpc { get; set; }
        public virtual ICollection<TouchpointLink> TouchpointLinks { get; set; }
    }
}
