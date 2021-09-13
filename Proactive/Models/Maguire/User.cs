using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class User
    {
        public User()
        {
            AccountUsIdSalesNavigations = new HashSet<Account>();
            AccountUsIdSupportNavigations = new HashSet<Account>();
            Activities = new HashSet<Activity>();
            Agreements = new HashSet<Agreement>();
            Alerts = new HashSet<Alert>();
            CallLogs = new HashSet<CallLog>();
            ContactSyncContacts = new HashSet<ContactSyncContact>();
            ContactSyncDates = new HashSet<ContactSyncDate>();
            Dashboards = new HashSet<Dashboard>();
            DataImportJobs = new HashSet<DataImportJob>();
            DesignScreenDedupeOverrideUsers = new HashSet<DesignScreenDedupeOverrideUser>();
            EmailJobs = new HashSet<EmailJob>();
            ImportContactJobs = new HashSet<ImportContactJob>();
            LmCallLogs = new HashSet<LmCallLog>();
            LmContactSpines = new HashSet<LmContactSpine>();
            LmImports = new HashSet<LmImport>();
            LmListcontrols = new HashSet<LmListcontrol>();
            MarketingCampaignStageRuns = new HashSet<MarketingCampaignStageRun>();
            MarketingCampaignStages = new HashSet<MarketingCampaignStage>();
            MarketingCampaigns = new HashSet<MarketingCampaign>();
            MarketingSources = new HashSet<MarketingSource>();
            Notes = new HashSet<Note>();
            Opportunities = new HashSet<Opportunity>();
            PortalVersion1s = new HashSet<PortalVersion1>();
            PortalVersions = new HashSet<PortalVersion>();
            Projects = new HashSet<Project>();
            Reports = new HashSet<Report>();
            SocialAuths = new HashSet<SocialAuth>();
            Spaces = new HashSet<Space>();
            TimeUnitsRecords = new HashSet<TimeUnitsRecord>();
            TouchpointConfigurationsData = new HashSet<TouchpointConfigurationsDatum>();
            UsersAppointments = new HashSet<UsersAppointment>();
            UsersFavorites = new HashSet<UsersFavorite>();
            UsersGadgets = new HashSet<UsersGadget>();
            UsersRecents = new HashSet<UsersRecent>();
            UsersReports = new HashSet<UsersReport>();
            UsersRights = new HashSet<UsersRight>();
            UsersTasks = new HashSet<UsersTask>();
        }

        public Guid? UsgId { get; set; }
        public Guid UsId { get; set; }
        public bool UsDeleted { get; set; }
        public Guid? Manager { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string Exchangeid { get; set; }
        public string EmailAddress { get; set; }
        public string NtAccount { get; set; }
        public string ExchangeServer { get; set; }
        public DateTime? LastScanned { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string UsUd1 { get; set; }
        public string UsUd2 { get; set; }
        public string UsUd3 { get; set; }
        public string UsUd4 { get; set; }
        public string UsUd5 { get; set; }
        public string UsUd6 { get; set; }
        public string UsUd7 { get; set; }
        public string UsUd8 { get; set; }
        public string UsUd9 { get; set; }
        public string UsUd10 { get; set; }
        public string UsUd11 { get; set; }
        public string UsUd12 { get; set; }
        public string UsUd13 { get; set; }
        public string UsUd14 { get; set; }
        public string UsUd15 { get; set; }
        public bool? Admin { get; set; }
        public bool? Sales { get; set; }
        public bool? Email { get; set; }
        public bool? Home { get; set; }
        public string AName { get; set; }
        public string ARef { get; set; }
        public string BName { get; set; }
        public string BRef { get; set; }
        public string CName { get; set; }
        public string CRef { get; set; }
        public string HomeName { get; set; }
        public string HomeRef { get; set; }
        public string UserJobTitle { get; set; }
        public string UserDirectPhone { get; set; }
        public string UserMobileTelephone { get; set; }
        public string UserDepartment { get; set; }
        public string TemplateFolder { get; set; }
        public string HashedPwd { get; set; }
        public Guid? SetIdPhone { get; set; }
        public bool? UseWordMailMerge { get; set; }
        public string PhoneCountryCode { get; set; }
        public string PhoneIddCode { get; set; }
        public string PhoneNddCode { get; set; }
        public string PhoneOutsideLineCode { get; set; }
        public Guid? CtId { get; set; }
        public bool? RootUser { get; set; }
        public decimal MonthlySalesTarget { get; set; }
        public string AddressLookupDetails { get; set; }
        public short? TimeDiff { get; set; }
        public string EmailScanDetails { get; set; }
        public string EmailScanFolders { get; set; }
        public string EmailScanExclusions { get; set; }
        public bool? EmailScanEmails { get; set; }
        public bool? EmailScanContacts { get; set; }
        public bool? EmailScanAppointments { get; set; }
        public bool? EmailScanTasks { get; set; }
        public int? EmailScanMaxSensitivity { get; set; }
        public string Lang { get; set; }
        public string UsExternal { get; set; }
        public bool? AccessEnabled { get; set; }
        public bool? AccessAdmin { get; set; }
        public bool? ShowOnUsers { get; set; }
        public bool? ShowOnAcManager { get; set; }
        public bool? ShowOnSupport { get; set; }
        public Guid? UsUd1Id { get; set; }
        public Guid? UsUd2Id { get; set; }
        public Guid? UsUd3Id { get; set; }
        public Guid? UsUd4Id { get; set; }
        public Guid? UsUd5Id { get; set; }
        public Guid? UsUd6Id { get; set; }
        public Guid? UsUd7Id { get; set; }
        public Guid? UsUd8Id { get; set; }
        public Guid? UsUd9Id { get; set; }
        public Guid? UsUd10Id { get; set; }
        public DateTime? UsUd1Date { get; set; }
        public DateTime? UsUd2Date { get; set; }
        public DateTime? UsUd3Date { get; set; }
        public DateTime? UsUd4Date { get; set; }
        public DateTime? UsUd5Date { get; set; }
        public DateTime? UsUd6Date { get; set; }
        public DateTime? UsUd7Date { get; set; }
        public DateTime? UsUd8Date { get; set; }
        public DateTime? UsUd9Date { get; set; }
        public DateTime? UsUd10Date { get; set; }
        public decimal? UsUd1Numeric { get; set; }
        public decimal? UsUd2Numeric { get; set; }
        public decimal? UsUd3Numeric { get; set; }
        public decimal? UsUd4Numeric { get; set; }
        public decimal? UsUd5Numeric { get; set; }
        public decimal? UsUd6Numeric { get; set; }
        public decimal? UsUd7Numeric { get; set; }
        public decimal? UsUd8Numeric { get; set; }
        public decimal? UsUd9Numeric { get; set; }
        public decimal? UsUd10Numeric { get; set; }
        public bool? UsUd1Bit { get; set; }
        public bool? UsUd2Bit { get; set; }
        public bool? UsUd3Bit { get; set; }
        public bool? UsUd4Bit { get; set; }
        public bool? UsUd5Bit { get; set; }
        public bool? UsUd6Bit { get; set; }
        public bool? UsUd7Bit { get; set; }
        public bool? UsUd8Bit { get; set; }
        public bool? UsUd9Bit { get; set; }
        public bool? UsUd10Bit { get; set; }
        public bool? UsUd11Bit { get; set; }
        public bool? UsUd12Bit { get; set; }
        public bool? UsUd13Bit { get; set; }
        public bool? UsUd14Bit { get; set; }
        public bool? UsUd15Bit { get; set; }
        public bool? UsUd16Bit { get; set; }
        public bool? UsUd17Bit { get; set; }
        public bool? UsUd18Bit { get; set; }
        public bool? UsUd19Bit { get; set; }
        public bool? UsUd20Bit { get; set; }
        public bool? UsUd21Bit { get; set; }
        public bool? UsUd22Bit { get; set; }
        public bool? UsUd23Bit { get; set; }
        public bool? UsUd24Bit { get; set; }
        public string DateFormat { get; set; }
        public string NumberFormat { get; set; }
        public Guid? CurId { get; set; }
        public bool? SingleWindow { get; set; }
        public bool? PrivateEmail { get; set; }
        public bool? SimpleViewMenu { get; set; }
        public int? CsIdLatest { get; set; }
        public DateTime? CsLatestDate { get; set; }
        public string TimeZone { get; set; }
        public bool? ShowOnCalendar { get; set; }
        public bool? EnableServerDocProd { get; set; }
        public bool? MapsAccess { get; set; }
        public string LivechatEmail { get; set; }
        public Guid? UsCulture { get; set; }
        public int? EsteiroidentSid { get; set; }
        public int ShortCode { get; set; }
        public Guid? LangId { get; set; }
        public string CultureCode { get; set; }
        public bool? IsActionCentrePinned { get; set; }
        public Guid? AcoTeamId { get; set; }
        public bool IsMenuExpanded { get; set; }
        public bool HybridEnabled { get; set; }
        public Guid HybridDefaultMode { get; set; }
        public Guid LicenceType { get; set; }
        public int? DocumentStorageView { get; set; }
        public string ShortCodePrefix { get; set; }
        public byte? CalendarView { get; set; }
        public byte? CalendarPeriod { get; set; }
        public byte? CalendarDuration { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual Language LangNavigation { get; set; }
        public virtual UsersGroup Usg { get; set; }
        public virtual ICollection<Account> AccountUsIdSalesNavigations { get; set; }
        public virtual ICollection<Account> AccountUsIdSupportNavigations { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
        public virtual ICollection<Alert> Alerts { get; set; }
        public virtual ICollection<CallLog> CallLogs { get; set; }
        public virtual ICollection<ContactSyncContact> ContactSyncContacts { get; set; }
        public virtual ICollection<ContactSyncDate> ContactSyncDates { get; set; }
        public virtual ICollection<Dashboard> Dashboards { get; set; }
        public virtual ICollection<DataImportJob> DataImportJobs { get; set; }
        public virtual ICollection<DesignScreenDedupeOverrideUser> DesignScreenDedupeOverrideUsers { get; set; }
        public virtual ICollection<EmailJob> EmailJobs { get; set; }
        public virtual ICollection<ImportContactJob> ImportContactJobs { get; set; }
        public virtual ICollection<LmCallLog> LmCallLogs { get; set; }
        public virtual ICollection<LmContactSpine> LmContactSpines { get; set; }
        public virtual ICollection<LmImport> LmImports { get; set; }
        public virtual ICollection<LmListcontrol> LmListcontrols { get; set; }
        public virtual ICollection<MarketingCampaignStageRun> MarketingCampaignStageRuns { get; set; }
        public virtual ICollection<MarketingCampaignStage> MarketingCampaignStages { get; set; }
        public virtual ICollection<MarketingCampaign> MarketingCampaigns { get; set; }
        public virtual ICollection<MarketingSource> MarketingSources { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Opportunity> Opportunities { get; set; }
        public virtual ICollection<PortalVersion1> PortalVersion1s { get; set; }
        public virtual ICollection<PortalVersion> PortalVersions { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<SocialAuth> SocialAuths { get; set; }
        public virtual ICollection<Space> Spaces { get; set; }
        public virtual ICollection<TimeUnitsRecord> TimeUnitsRecords { get; set; }
        public virtual ICollection<TouchpointConfigurationsDatum> TouchpointConfigurationsData { get; set; }
        public virtual ICollection<UsersAppointment> UsersAppointments { get; set; }
        public virtual ICollection<UsersFavorite> UsersFavorites { get; set; }
        public virtual ICollection<UsersGadget> UsersGadgets { get; set; }
        public virtual ICollection<UsersRecent> UsersRecents { get; set; }
        public virtual ICollection<UsersReport> UsersReports { get; set; }
        public virtual ICollection<UsersRight> UsersRights { get; set; }
        public virtual ICollection<UsersTask> UsersTasks { get; set; }
    }
}
