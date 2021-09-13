using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MailCampaign
    {
        public MailCampaign()
        {
            Activities = new HashSet<Activity>();
            MailCampaignsAccounts = new HashSet<MailCampaignsAccount>();
            MailCampaignsAttachments = new HashSet<MailCampaignsAttachment>();
            MailCampaignsContactsSents = new HashSet<MailCampaignsContactsSent>();
            MailCampaignsContactsUnsents = new HashSet<MailCampaignsContactsUnsent>();
            MailCampaignsRuns = new HashSet<MailCampaignsRun>();
            MailCampaignsSources = new HashSet<MailCampaignsSource>();
            Opportunities = new HashSet<Opportunity>();
        }

        public Guid MacId { get; set; }
        public bool MacDeleted { get; set; }
        public Guid? MacOwner { get; set; }
        public Guid? MacType { get; set; }
        public bool? MacStatus { get; set; }
        public string MacQuery { get; set; }
        public bool? MacTarget { get; set; }
        public int? MacMedium { get; set; }
        public int? MacMediumFilter { get; set; }
        public bool? MacActivities { get; set; }
        public string MacSubject { get; set; }
        public string MacBody { get; set; }
        public string MacTemplate { get; set; }
        public DateTime? ScheduledDate { get; set; }
        public DateTime? RunDate { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public Guid? AccaStage { get; set; }
        public Guid? AccaOwner { get; set; }
        public bool UsIdSales { get; set; }
        public Guid? MacDonor { get; set; }
        public DateTime? AccaStartDate { get; set; }
        public DateTime? AccaDueDate { get; set; }
        public Guid? ParentId { get; set; }
        public string DefaultSalutation { get; set; }
        public string MacExternal { get; set; }
        public string DefaultRecipient { get; set; }
        public string MacUdInfo { get; set; }
        public string MacUdMoreInfo { get; set; }
        public string MacUd1 { get; set; }
        public string MacUd2 { get; set; }
        public string MacUd3 { get; set; }
        public string MacUd4 { get; set; }
        public string MacUd5 { get; set; }
        public string MacUd6 { get; set; }
        public string MacUd7 { get; set; }
        public string MacUd8 { get; set; }
        public string MacUd9 { get; set; }
        public string MacUd10 { get; set; }
        public DateTime? MacUd1Date { get; set; }
        public DateTime? MacUd2Date { get; set; }
        public DateTime? MacUd3Date { get; set; }
        public DateTime? MacUd4Date { get; set; }
        public DateTime? MacUd5Date { get; set; }
        public DateTime? MacUd6Date { get; set; }
        public DateTime? MacUd7Date { get; set; }
        public DateTime? MacUd8Date { get; set; }
        public DateTime? MacUd9Date { get; set; }
        public DateTime? MacUd10Date { get; set; }
        public Guid? MacUd1Id { get; set; }
        public Guid? MacUd2Id { get; set; }
        public Guid? MacUd3Id { get; set; }
        public Guid? MacUd4Id { get; set; }
        public Guid? MacUd5Id { get; set; }
        public Guid? MacUd6Id { get; set; }
        public Guid? MacUd7Id { get; set; }
        public Guid? MacUd8Id { get; set; }
        public Guid? MacUd9Id { get; set; }
        public Guid? MacUd10Id { get; set; }
        public bool? MacUd1Bit { get; set; }
        public bool? MacUd2Bit { get; set; }
        public bool? MacUd3Bit { get; set; }
        public bool? MacUd4Bit { get; set; }
        public bool? MacUd5Bit { get; set; }
        public bool? MacUd6Bit { get; set; }
        public bool? MacUd7Bit { get; set; }
        public bool? MacUd8Bit { get; set; }
        public bool? MacUd9Bit { get; set; }
        public bool? MacUd10Bit { get; set; }
        public decimal? MacUd1Numeric { get; set; }
        public decimal? MacUd2Numeric { get; set; }
        public decimal? MacUd3Numeric { get; set; }
        public decimal? MacUd4Numeric { get; set; }
        public decimal? MacUd5Numeric { get; set; }
        public decimal? MacUd6Numeric { get; set; }
        public decimal? MacUd7Numeric { get; set; }
        public decimal? MacUd8Numeric { get; set; }
        public decimal? MacUd9Numeric { get; set; }
        public decimal? MacUd10Numeric { get; set; }
        public Guid? MacStage { get; set; }
        public string Reference { get; set; }
        public bool? MacUd11Bit { get; set; }
        public bool? MacUd12Bit { get; set; }
        public bool? MacUd13Bit { get; set; }
        public bool? MacUd14Bit { get; set; }
        public bool? MacUd15Bit { get; set; }
        public bool? MacUd16Bit { get; set; }
        public bool? MacUd17Bit { get; set; }
        public bool? MacUd18Bit { get; set; }
        public bool? MacUd19Bit { get; set; }
        public bool? MacUd20Bit { get; set; }
        public bool? MacUd21Bit { get; set; }
        public bool? MacUd22Bit { get; set; }
        public bool? MacUd23Bit { get; set; }
        public bool? MacUd24Bit { get; set; }
        public decimal? MacCost { get; set; }
        public byte? ConnectOptInType { get; set; }
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<MailCampaignsAccount> MailCampaignsAccounts { get; set; }
        public virtual ICollection<MailCampaignsAttachment> MailCampaignsAttachments { get; set; }
        public virtual ICollection<MailCampaignsContactsSent> MailCampaignsContactsSents { get; set; }
        public virtual ICollection<MailCampaignsContactsUnsent> MailCampaignsContactsUnsents { get; set; }
        public virtual ICollection<MailCampaignsRun> MailCampaignsRuns { get; set; }
        public virtual ICollection<MailCampaignsSource> MailCampaignsSources { get; set; }
        public virtual ICollection<Opportunity> Opportunities { get; set; }
    }
}
