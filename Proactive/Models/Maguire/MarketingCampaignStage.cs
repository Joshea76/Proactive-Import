﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MarketingCampaignStage
    {
        public MarketingCampaignStage()
        {
            InverseStgIdParentNavigation = new HashSet<MarketingCampaignStage>();
            MarketingCampaignStageMessages = new HashSet<MarketingCampaignStageMessage>();
            MarketingCampaignStageRecipients = new HashSet<MarketingCampaignStageRecipient>();
            MarketingCampaignStageRunResults = new HashSet<MarketingCampaignStageRunResult>();
            MarketingCampaignStageRuns = new HashSet<MarketingCampaignStageRun>();
            Touchpoints = new HashSet<Touchpoint>();
        }

        public Guid StgId { get; set; }
        public Guid? StgIdParent { get; set; }
        public Guid McaId { get; set; }
        public Guid? UsId { get; set; }
        public string Summary { get; set; }
        public Guid? Type { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? LastRefresh { get; set; }
        public string LastRefreshBy { get; set; }
        public DateTime? RunDate { get; set; }
        public string RunBy { get; set; }
        public DateTime? LastRunDate { get; set; }
        public string LastRunBy { get; set; }
        public byte MediaType { get; set; }
        public byte StageType { get; set; }
        public byte State { get; set; }
        public bool Stale { get; set; }
        public string TemplateName { get; set; }
        public byte? ActCreate { get; set; }
        public DateTime? ActStartDate { get; set; }
        public DateTime? ActDueDate { get; set; }
        public Guid? ActOwner { get; set; }
        public bool? ActAcManager { get; set; }
        public Guid? ActStage { get; set; }
        public string DefaultSalutation { get; set; }
        public string DefaultRecipient { get; set; }
        public string Reference { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public decimal? CCostVal { get; set; }
        public decimal? COpenVal { get; set; }
        public decimal? CWonVal { get; set; }
        public decimal? CLostVal { get; set; }
        public decimal? CProfitVal { get; set; }
        public int? CTotal { get; set; }
        public int? CValid { get; set; }
        public int? CValidEmail { get; set; }
        public int? CValidFax { get; set; }
        public int? CValidLetter { get; set; }
        public int? CValidPhone { get; set; }
        public int? CValidMobile { get; set; }
        public int? CTltEmailsOpened { get; set; }
        public int? CTltEmailsClicked { get; set; }
        public int? CTltEmailsDelivered { get; set; }
        public int? CTltEmailsReplied { get; set; }
        public int? CTltEmailsForwarded { get; set; }
        public int? CTltEmailsBounced { get; set; }
        public int? CTltEmailsUnsubthis { get; set; }
        public int? CTltEmailsUnsuball { get; set; }
        public int? CUnqEmailsOpened { get; set; }
        public int? CUnqEmailsClicked { get; set; }
        public int? CUnqEmailsDelivered { get; set; }
        public int? CUnqEmailsReplied { get; set; }
        public int? CUnqEmailsForwarded { get; set; }
        public int? CUnqEmailsBounced { get; set; }
        public int? CUnqEmailsUnsubthis { get; set; }
        public int? CUnqEmailsUnsuball { get; set; }
        public int? CTotalSent { get; set; }
        public int? CUniqueSent { get; set; }
        public int? CRuns { get; set; }
        public int? CTltAppointments { get; set; }
        public int? CUnqAppointments { get; set; }
        public int? CCompleteAppointments { get; set; }
        public int? CTltOpportunities { get; set; }
        public int? COpenOpportunities { get; set; }
        public int? CWonOpportunities { get; set; }
        public int? CLostOpportunities { get; set; }
        public int? CTotalAct { get; set; }
        public int? CUniqueAct { get; set; }
        public int? CCompleteAct { get; set; }
        public int? CBookings { get; set; }
        public int? CBookingsConfirmed { get; set; }
        public decimal? CBookingsWonVal { get; set; }
        public decimal? CBookingsOpenVal { get; set; }
        public string StgUd1 { get; set; }
        public string StgUd2 { get; set; }
        public string StgUd3 { get; set; }
        public string StgUd4 { get; set; }
        public string StgUd5 { get; set; }
        public string StgUd6 { get; set; }
        public string StgUd7 { get; set; }
        public string StgUd8 { get; set; }
        public string StgUd9 { get; set; }
        public string StgUd10 { get; set; }
        public Guid? StgUd1Id { get; set; }
        public Guid? StgUd2Id { get; set; }
        public Guid? StgUd3Id { get; set; }
        public Guid? StgUd4Id { get; set; }
        public Guid? StgUd5Id { get; set; }
        public Guid? StgUd6Id { get; set; }
        public Guid? StgUd7Id { get; set; }
        public Guid? StgUd8Id { get; set; }
        public Guid? StgUd9Id { get; set; }
        public Guid? StgUd10Id { get; set; }
        public DateTime? StgUd1Date { get; set; }
        public DateTime? StgUd2Date { get; set; }
        public DateTime? StgUd3Date { get; set; }
        public DateTime? StgUd4Date { get; set; }
        public DateTime? StgUd5Date { get; set; }
        public DateTime? StgUd6Date { get; set; }
        public DateTime? StgUd7Date { get; set; }
        public DateTime? StgUd8Date { get; set; }
        public DateTime? StgUd9Date { get; set; }
        public DateTime? StgUd10Date { get; set; }
        public bool? StgUd1Bit { get; set; }
        public bool? StgUd2Bit { get; set; }
        public bool? StgUd3Bit { get; set; }
        public bool? StgUd4Bit { get; set; }
        public bool? StgUd5Bit { get; set; }
        public bool? StgUd6Bit { get; set; }
        public bool? StgUd7Bit { get; set; }
        public bool? StgUd8Bit { get; set; }
        public bool? StgUd9Bit { get; set; }
        public bool? StgUd10Bit { get; set; }
        public bool? StgUd11Bit { get; set; }
        public bool? StgUd12Bit { get; set; }
        public bool? StgUd13Bit { get; set; }
        public bool? StgUd14Bit { get; set; }
        public bool? StgUd15Bit { get; set; }
        public bool? StgUd16Bit { get; set; }
        public bool? StgUd17Bit { get; set; }
        public bool? StgUd18Bit { get; set; }
        public bool? StgUd19Bit { get; set; }
        public bool? StgUd20Bit { get; set; }
        public bool? StgUd21Bit { get; set; }
        public bool? StgUd22Bit { get; set; }
        public bool? StgUd23Bit { get; set; }
        public bool? StgUd24Bit { get; set; }
        public decimal? StgUd1Numeric { get; set; }
        public decimal? StgUd2Numeric { get; set; }
        public decimal? StgUd3Numeric { get; set; }
        public decimal? StgUd4Numeric { get; set; }
        public decimal? StgUd5Numeric { get; set; }
        public decimal? StgUd6Numeric { get; set; }
        public decimal? StgUd7Numeric { get; set; }
        public decimal? StgUd8Numeric { get; set; }
        public decimal? StgUd9Numeric { get; set; }
        public decimal? StgUd10Numeric { get; set; }
        public bool IsAutomated { get; set; }
        public byte AutoFreq { get; set; }
        public byte AutoDay { get; set; }
        public byte AutoMonth { get; set; }
        public bool AutoAllrecp { get; set; }
        public DateTime? AutoStart { get; set; }
        public DateTime? AutoEnd { get; set; }
        public DateTime? AutoLastSent { get; set; }
        public short AutoTime { get; set; }
        public int? AutoMstId { get; set; }
        public string AutoTemplate { get; set; }
        public bool? Closed { get; set; }
        public short? AutoWeekDays { get; set; }
        public bool IsPrivacyNotified { get; set; }
        public string PrivacyNotificationReason { get; set; }
        public bool? OptInsOnly { get; set; }
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }
        public string Details { get; set; }

        public virtual MarketingCampaign Mca { get; set; }
        public virtual MarketingCampaignStage StgIdParentNavigation { get; set; }
        public virtual User Us { get; set; }
        public virtual StgBit StgBit { get; set; }
        public virtual StgDate StgDate { get; set; }
        public virtual StgNum StgNum { get; set; }
        public virtual StgTxt StgTxt { get; set; }
        public virtual StgUid StgUid { get; set; }
        public virtual ICollection<MarketingCampaignStage> InverseStgIdParentNavigation { get; set; }
        public virtual ICollection<MarketingCampaignStageMessage> MarketingCampaignStageMessages { get; set; }
        public virtual ICollection<MarketingCampaignStageRecipient> MarketingCampaignStageRecipients { get; set; }
        public virtual ICollection<MarketingCampaignStageRunResult> MarketingCampaignStageRunResults { get; set; }
        public virtual ICollection<MarketingCampaignStageRun> MarketingCampaignStageRuns { get; set; }
        public virtual ICollection<Touchpoint> Touchpoints { get; set; }
    }
}
