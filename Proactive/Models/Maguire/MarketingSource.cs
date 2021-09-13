using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MarketingSource
    {
        public MarketingSource()
        {
            MarketingCampaignStageRecipients = new HashSet<MarketingCampaignStageRecipient>();
            MarketingCampaignStageRunResults = new HashSet<MarketingCampaignStageRunResult>();
            MarketingSourceRules = new HashSet<MarketingSourceRule>();
        }

        public Guid SrcId { get; set; }
        public byte SrcType { get; set; }
        public string SrcExternal { get; set; }
        public string Reference { get; set; }
        public Guid? Type { get; set; }
        public string Summary { get; set; }
        public Guid? UsId { get; set; }
        public byte PrefEmail { get; set; }
        public byte PrefPhone { get; set; }
        public byte PrefFax { get; set; }
        public byte PrefLetter { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public bool Dormant { get; set; }
        public DateTime? DormantDate { get; set; }
        public string DormantBy { get; set; }
        public byte? State { get; set; }
        public DateTime? LastRefresh { get; set; }
        public string LastRefreshBy { get; set; }
        public DateTime? LastRuleChange { get; set; }
        public string LastRuleChangeBy { get; set; }
        public int CValidEmail { get; set; }
        public int CValidPhone { get; set; }
        public int CValidFax { get; set; }
        public int CValidLetter { get; set; }
        public int? CValidSms { get; set; }
        public int? CIncludedContacts { get; set; }
        public int? CExcludedContacts { get; set; }
        public int? CIncludedItems { get; set; }
        public int? CExcludedItems { get; set; }
        public int CTotal { get; set; }
        public string SrcUd1 { get; set; }
        public string SrcUd2 { get; set; }
        public string SrcUd3 { get; set; }
        public string SrcUd4 { get; set; }
        public string SrcUd5 { get; set; }
        public string SrcUd6 { get; set; }
        public string SrcUd7 { get; set; }
        public string SrcUd8 { get; set; }
        public string SrcUd9 { get; set; }
        public string SrcUd10 { get; set; }
        public Guid? SrcUd1Id { get; set; }
        public Guid? SrcUd2Id { get; set; }
        public Guid? SrcUd3Id { get; set; }
        public Guid? SrcUd4Id { get; set; }
        public Guid? SrcUd5Id { get; set; }
        public Guid? SrcUd6Id { get; set; }
        public Guid? SrcUd7Id { get; set; }
        public Guid? SrcUd8Id { get; set; }
        public Guid? SrcUd9Id { get; set; }
        public Guid? SrcUd10Id { get; set; }
        public DateTime? SrcUd1Date { get; set; }
        public DateTime? SrcUd2Date { get; set; }
        public DateTime? SrcUd3Date { get; set; }
        public DateTime? SrcUd4Date { get; set; }
        public DateTime? SrcUd5Date { get; set; }
        public DateTime? SrcUd6Date { get; set; }
        public DateTime? SrcUd7Date { get; set; }
        public DateTime? SrcUd8Date { get; set; }
        public DateTime? SrcUd9Date { get; set; }
        public DateTime? SrcUd10Date { get; set; }
        public bool? SrcUd1Bit { get; set; }
        public bool? SrcUd2Bit { get; set; }
        public bool? SrcUd3Bit { get; set; }
        public bool? SrcUd4Bit { get; set; }
        public bool? SrcUd5Bit { get; set; }
        public bool? SrcUd6Bit { get; set; }
        public bool? SrcUd7Bit { get; set; }
        public bool? SrcUd8Bit { get; set; }
        public bool? SrcUd9Bit { get; set; }
        public bool? SrcUd10Bit { get; set; }
        public bool? SrcUd11Bit { get; set; }
        public bool? SrcUd12Bit { get; set; }
        public bool? SrcUd13Bit { get; set; }
        public bool? SrcUd14Bit { get; set; }
        public bool? SrcUd15Bit { get; set; }
        public bool? SrcUd16Bit { get; set; }
        public bool? SrcUd17Bit { get; set; }
        public bool? SrcUd18Bit { get; set; }
        public bool? SrcUd19Bit { get; set; }
        public bool? SrcUd20Bit { get; set; }
        public bool? SrcUd21Bit { get; set; }
        public bool? SrcUd22Bit { get; set; }
        public bool? SrcUd23Bit { get; set; }
        public bool? SrcUd24Bit { get; set; }
        public decimal? SrcUd1Numeric { get; set; }
        public decimal? SrcUd2Numeric { get; set; }
        public decimal? SrcUd3Numeric { get; set; }
        public decimal? SrcUd4Numeric { get; set; }
        public decimal? SrcUd5Numeric { get; set; }
        public decimal? SrcUd6Numeric { get; set; }
        public decimal? SrcUd7Numeric { get; set; }
        public decimal? SrcUd8Numeric { get; set; }
        public decimal? SrcUd9Numeric { get; set; }
        public decimal? SrcUd10Numeric { get; set; }
        public int? CTimesSentTotal { get; set; }
        public int? CTimesSentEmail { get; set; }
        public int? CTimesSentPhone { get; set; }
        public int? CTimesSentFax { get; set; }
        public int? CTimesSentLetter { get; set; }
        public int? CEmailsOpened { get; set; }
        public int? CEmailsClicked { get; set; }
        public int? CEmailsDelivered { get; set; }
        public int? CEmailsRunningtotal { get; set; }
        public int? CEmailsReplied { get; set; }
        public int? CEmailsForwarded { get; set; }
        public int? CEmailsBounced { get; set; }
        public int? CPhoneRunningtotal { get; set; }
        public int? CFaxRunningtotal { get; set; }
        public int? CLetterRunningtotal { get; set; }
        public int? Status { get; set; }
        public Guid? SgId { get; set; }
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual User Us { get; set; }
        public virtual SrcBit SrcBit { get; set; }
        public virtual SrcDate SrcDate { get; set; }
        public virtual SrcNum SrcNum { get; set; }
        public virtual SrcTxt SrcTxt { get; set; }
        public virtual SrcUid SrcUid { get; set; }
        public virtual ICollection<MarketingCampaignStageRecipient> MarketingCampaignStageRecipients { get; set; }
        public virtual ICollection<MarketingCampaignStageRunResult> MarketingCampaignStageRunResults { get; set; }
        public virtual ICollection<MarketingSourceRule> MarketingSourceRules { get; set; }
    }
}
