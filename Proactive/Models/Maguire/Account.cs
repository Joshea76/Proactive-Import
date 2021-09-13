using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Account
    {
        public Account()
        {
            AccountsContacts = new HashSet<AccountsContact>();
            AccountsProfiles = new HashSet<AccountsProfile>();
            Activities = new HashSet<Activity>();
            Agreements = new HashSet<Agreement>();
            CallLogs = new HashSet<CallLog>();
            Correspondences = new HashSet<Correspondence>();
            Documents = new HashSet<Document>();
            Events = new HashSet<Event>();
            ImportContactJobs = new HashSet<ImportContactJob>();
            IntAccountingTransactionHistoryAcs = new HashSet<IntAccountingTransactionHistory>();
            IntAccountingTransactionHistoryObjs = new HashSet<IntAccountingTransactionHistory>();
            IntAnagramDespatches = new HashSet<IntAnagramDespatch>();
            IntAnagramTransactions = new HashSet<IntAnagramTransaction>();
            IntNavisionTransactionHistoryAcs = new HashSet<IntNavisionTransactionHistory>();
            IntNavisionTransactionHistoryObjs = new HashSet<IntNavisionTransactionHistory>();
            IntWinManTransactionHistoryAcs = new HashSet<IntWinManTransactionHistory>();
            IntWinManTransactionHistoryObjs = new HashSet<IntWinManTransactionHistory>();
            IntXeroTransactionHistoryAcs = new HashSet<IntXeroTransactionHistory>();
            IntXeroTransactionHistoryObjs = new HashSet<IntXeroTransactionHistory>();
            LmContactSpines = new HashSet<LmContactSpine>();
            MailCampaignsAccounts = new HashSet<MailCampaignsAccount>();
            MailCampaignsContactsSentClicks = new HashSet<MailCampaignsContactsSentClick>();
            MarketingCampaignStageRecipients = new HashSet<MarketingCampaignStageRecipient>();
            MarketingCampaignStageRunResults = new HashSet<MarketingCampaignStageRunResult>();
            MarketingSourceRecipients = new HashSet<MarketingSourceRecipient>();
            Notes = new HashSet<Note>();
            Opportunities = new HashSet<Opportunity>();
            OpportunitiesQuotes = new HashSet<OpportunitiesQuote>();
            OpportunitiesQuotesDetails = new HashSet<OpportunitiesQuotesDetail>();
            Projects = new HashSet<Project>();
            SeminarsBookings = new HashSet<SeminarsBooking>();
            SeminarsBookingsAttendees = new HashSet<SeminarsBookingsAttendee>();
            Sites = new HashSet<Site>();
            TimeUnitsRecords = new HashSet<TimeUnitsRecord>();
            UsersAppointments = new HashSet<UsersAppointment>();
            UsersRecents = new HashSet<UsersRecent>();
            UsersTasks = new HashSet<UsersTask>();
        }

        public Guid? AcgId { get; set; }
        public Guid AcId { get; set; }
        public bool? AcDeleted { get; set; }
        public string AcNumber { get; set; }
        public decimal? AcPotential { get; set; }
        public decimal AcDiscount { get; set; }
        public Guid? AcFlag { get; set; }
        public string Name { get; set; }
        public Guid? UsIdSales { get; set; }
        public Guid? UsIdSupport { get; set; }
        public Guid? Type1 { get; set; }
        public Guid? Type2 { get; set; }
        public string Site { get; set; }
        public Guid? Parent { get; set; }
        public Guid? Label { get; set; }
        public Guid? Level { get; set; }
        public Guid? AccIdSales { get; set; }
        public Guid? AccIdSupport { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingAddress3 { get; set; }
        public string BillingTown { get; set; }
        public string BillingCounty { get; set; }
        public string BillingPostcode { get; set; }
        public string BillingCountry { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Fax3 { get; set; }
        public string WebSite1 { get; set; }
        public string WebSite2 { get; set; }
        public Guid? Source { get; set; }
        public Guid? Industry { get; set; }
        public string NumberEmployees { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string AcUd1 { get; set; }
        public string AcUd2 { get; set; }
        public string AcUd3 { get; set; }
        public string AcUd4 { get; set; }
        public string AcUd5 { get; set; }
        public string AcUd6 { get; set; }
        public string AcUd7 { get; set; }
        public string AcUd8 { get; set; }
        public string AcUd9 { get; set; }
        public string AcUd10 { get; set; }
        public string AcUd11 { get; set; }
        public string AcUd12 { get; set; }
        public string AcUd13 { get; set; }
        public string AcUd14 { get; set; }
        public string AcUd15 { get; set; }
        public Guid? AcImport { get; set; }
        public string AcExternal { get; set; }
        public DateTime? AcUd1Date { get; set; }
        public DateTime? AcUd2Date { get; set; }
        public DateTime? AcUd3Date { get; set; }
        public DateTime? AcUd4Date { get; set; }
        public DateTime? AcUd5Date { get; set; }
        public DateTime? AcUd6Date { get; set; }
        public DateTime? AcUd7Date { get; set; }
        public DateTime? AcUd8Date { get; set; }
        public DateTime? AcUd9Date { get; set; }
        public DateTime? AcUd10Date { get; set; }
        public Guid? AcUd1Id { get; set; }
        public Guid? AcUd2Id { get; set; }
        public Guid? AcUd3Id { get; set; }
        public Guid? AcUd4Id { get; set; }
        public Guid? AcUd5Id { get; set; }
        public Guid? AcUd6Id { get; set; }
        public Guid? AcUd7Id { get; set; }
        public Guid? AcUd8Id { get; set; }
        public Guid? AcUd9Id { get; set; }
        public Guid? AcUd10Id { get; set; }
        public bool? AcUd1Bit { get; set; }
        public bool? AcUd2Bit { get; set; }
        public bool? AcUd3Bit { get; set; }
        public bool? AcUd4Bit { get; set; }
        public bool? AcUd5Bit { get; set; }
        public bool? AcUd6Bit { get; set; }
        public bool? AcUd7Bit { get; set; }
        public bool? AcUd8Bit { get; set; }
        public bool? AcUd9Bit { get; set; }
        public bool? AcUd10Bit { get; set; }
        public decimal? AcUd1Numeric { get; set; }
        public decimal? AcUd2Numeric { get; set; }
        public decimal? AcUd3Numeric { get; set; }
        public decimal? AcUd4Numeric { get; set; }
        public decimal? AcUd5Numeric { get; set; }
        public decimal? AcUd6Numeric { get; set; }
        public decimal? AcUd7Numeric { get; set; }
        public decimal? AcUd8Numeric { get; set; }
        public decimal? AcUd9Numeric { get; set; }
        public decimal? AcUd10Numeric { get; set; }
        public bool? AcDormant { get; set; }
        public string Validationmessage { get; set; }
        public string EmailDomains { get; set; }
        public Guid? CurId { get; set; }
        public string Reference { get; set; }
        public int? ReferenceSeed { get; set; }
        public bool? AcUd11Bit { get; set; }
        public bool? AcUd12Bit { get; set; }
        public bool? AcUd13Bit { get; set; }
        public bool? AcUd14Bit { get; set; }
        public bool? AcUd15Bit { get; set; }
        public bool? AcUd16Bit { get; set; }
        public bool? AcUd17Bit { get; set; }
        public bool? AcUd18Bit { get; set; }
        public bool? AcUd19Bit { get; set; }
        public bool? AcUd20Bit { get; set; }
        public bool? AcUd21Bit { get; set; }
        public bool? AcUd22Bit { get; set; }
        public bool? AcUd23Bit { get; set; }
        public bool? AcUd24Bit { get; set; }
        public decimal? AcSales { get; set; }
        public string LinkedinName { get; set; }
        public string NameSoundex { get; set; }
        public string NameLongestWord { get; set; }
        public int? CsId { get; set; }
        public int ShortCode { get; set; }
        public string Sentiment { get; set; }
        public Guid? PrimarySitId { get; set; }
        public Guid? BillingSitId { get; set; }
        public int EstimatedUnits { get; set; }
        public int EstimatedTime { get; set; }
        public int ActualUnits { get; set; }
        public int ActualTime { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }
        public Guid? CurIdBilling { get; set; }

        public virtual AccountsGroup Acg { get; set; }
        public virtual Currency Cur { get; set; }
        public virtual Currency CurIdBillingNavigation { get; set; }
        public virtual User UsIdSalesNavigation { get; set; }
        public virtual User UsIdSupportNavigation { get; set; }
        public virtual AcBit AcBit { get; set; }
        public virtual AcDate AcDate { get; set; }
        public virtual AcNum AcNum { get; set; }
        public virtual AcTxt AcTxt { get; set; }
        public virtual AcUid AcUid { get; set; }
        public virtual AccountsValue AccountsValue { get; set; }
        public virtual ICollection<AccountsContact> AccountsContacts { get; set; }
        public virtual ICollection<AccountsProfile> AccountsProfiles { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
        public virtual ICollection<CallLog> CallLogs { get; set; }
        public virtual ICollection<Correspondence> Correspondences { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<ImportContactJob> ImportContactJobs { get; set; }
        public virtual ICollection<IntAccountingTransactionHistory> IntAccountingTransactionHistoryAcs { get; set; }
        public virtual ICollection<IntAccountingTransactionHistory> IntAccountingTransactionHistoryObjs { get; set; }
        public virtual ICollection<IntAnagramDespatch> IntAnagramDespatches { get; set; }
        public virtual ICollection<IntAnagramTransaction> IntAnagramTransactions { get; set; }
        public virtual ICollection<IntNavisionTransactionHistory> IntNavisionTransactionHistoryAcs { get; set; }
        public virtual ICollection<IntNavisionTransactionHistory> IntNavisionTransactionHistoryObjs { get; set; }
        public virtual ICollection<IntWinManTransactionHistory> IntWinManTransactionHistoryAcs { get; set; }
        public virtual ICollection<IntWinManTransactionHistory> IntWinManTransactionHistoryObjs { get; set; }
        public virtual ICollection<IntXeroTransactionHistory> IntXeroTransactionHistoryAcs { get; set; }
        public virtual ICollection<IntXeroTransactionHistory> IntXeroTransactionHistoryObjs { get; set; }
        public virtual ICollection<LmContactSpine> LmContactSpines { get; set; }
        public virtual ICollection<MailCampaignsAccount> MailCampaignsAccounts { get; set; }
        public virtual ICollection<MailCampaignsContactsSentClick> MailCampaignsContactsSentClicks { get; set; }
        public virtual ICollection<MarketingCampaignStageRecipient> MarketingCampaignStageRecipients { get; set; }
        public virtual ICollection<MarketingCampaignStageRunResult> MarketingCampaignStageRunResults { get; set; }
        public virtual ICollection<MarketingSourceRecipient> MarketingSourceRecipients { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Opportunity> Opportunities { get; set; }
        public virtual ICollection<OpportunitiesQuote> OpportunitiesQuotes { get; set; }
        public virtual ICollection<OpportunitiesQuotesDetail> OpportunitiesQuotesDetails { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<SeminarsBooking> SeminarsBookings { get; set; }
        public virtual ICollection<SeminarsBookingsAttendee> SeminarsBookingsAttendees { get; set; }
        public virtual ICollection<Site> Sites { get; set; }
        public virtual ICollection<TimeUnitsRecord> TimeUnitsRecords { get; set; }
        public virtual ICollection<UsersAppointment> UsersAppointments { get; set; }
        public virtual ICollection<UsersRecent> UsersRecents { get; set; }
        public virtual ICollection<UsersTask> UsersTasks { get; set; }
    }
}
