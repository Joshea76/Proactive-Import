using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class AspNetUser
    {
        public AspNetUser()
        {
            Activities = new HashSet<Activity>();
            ActivityTypes = new HashSet<ActivityType>();
            AnnouncementEmailUnsubscribers = new HashSet<AnnouncementEmailUnsubscriber>();
            AspNetUserClaims = new HashSet<AspNetUserClaim>();
            AspNetUserLogins = new HashSet<AspNetUserLogin>();
            AspNetUserRoles = new HashSet<AspNetUserRole>();
            AutoResponders = new HashSet<AutoResponder>();
            Campaigns = new HashSet<Campaign>();
            Cats = new HashSet<Cat>();
            Checklists = new HashSet<Checklist>();
            ContactAndLists = new HashSet<ContactAndList>();
            ContactFiles = new HashSet<ContactFile>();
            ContactNotes = new HashSet<ContactNote>();
            ContactProcessStages = new HashSet<ContactProcessStage>();
            ContactProcessSteps = new HashSet<ContactProcessStep>();
            ContactTitles = new HashSet<ContactTitle>();
            ContactToDoFields = new HashSet<ContactToDoField>();
            ContactTypes = new HashSet<ContactType>();
            Contacts = new HashSet<Contact>();
            CountUpTimers = new HashSet<CountUpTimer>();
            Countries = new HashSet<Country>();
            DeletedContacts = new HashSet<DeletedContact>();
            DynamicLabels = new HashSet<DynamicLabel>();
            Emails = new HashSet<Email>();
            Followups = new HashSet<Followup>();
            Gdprconsents = new HashSet<Gdprconsent>();
            GoalWins = new HashSet<GoalWin>();
            Goals = new HashSet<Goal>();
            GoogleTokens = new HashSet<GoogleToken>();
            InvoiceItems = new HashSet<InvoiceItem>();
            InvoicePayments = new HashSet<InvoicePayment>();
            Invoices = new HashSet<Invoice>();
            JobHeaders = new HashSet<JobHeader>();
            JobItems = new HashSet<JobItem>();
            JobNotes = new HashSet<JobNote>();
            Jobs = new HashSet<Job>();
            LessonCompleteds = new HashSet<LessonCompleted>();
            Lessons = new HashSet<Lesson>();
            MailchimpCampaigns = new HashSet<MailchimpCampaign>();
            MarketingLists = new HashSet<MarketingList>();
            MyNotes = new HashSet<MyNote>();
            MySettings = new HashSet<MySetting>();
            Opportunities = new HashSet<Opportunity>();
            OpportunityStageHistories = new HashSet<OpportunityStageHistory>();
            OpportunityStages = new HashSet<OpportunityStage>();
            OrgAccountManagers = new HashSet<Org>();
            OrgCustomSelects = new HashSet<OrgCustomSelect>();
            OrgSavedFilters = new HashSet<OrgSavedFilter>();
            OrgTodoTypes = new HashSet<OrgTodoType>();
            OrgUsers = new HashSet<Org>();
            OutlookIntegrations = new HashSet<OutlookIntegration>();
            ProcessSteps = new HashSet<ProcessStep>();
            Processes = new HashSet<Process>();
            Products = new HashSet<Product>();
            ProjectNotes = new HashSet<ProjectNote>();
            Projects = new HashSet<Project>();
            QuickNotes = new HashSet<QuickNote>();
            QuoteAssignedUsers = new HashSet<Quote>();
            QuoteItems = new HashSet<QuoteItem>();
            QuoteUsers = new HashSet<Quote>();
            QuotesSavedFilters = new HashSet<QuotesSavedFilter>();
            RitualDays = new HashSet<RitualDay>();
            Rituals = new HashSet<Ritual>();
            SalesProcesses = new HashSet<SalesProcess>();
            SalesStepGroups = new HashSet<SalesStepGroup>();
            SalesSteps = new HashSet<SalesStep>();
            SkypeCalls = new HashSet<SkypeCall>();
            Sources = new HashSet<Source>();
            SubjectUsers = new HashSet<SubjectUser>();
            Subjects = new HashSet<Subject>();
            SystemEmailSubscriptions = new HashSet<SystemEmailSubscription>();
            TemplateTypes = new HashSet<TemplateType>();
            Templates = new HashSet<Template>();
            TodoAssignedUsers = new HashSet<Todo>();
            TodoCategories = new HashSet<TodoCategory>();
            TodoCustomSelects = new HashSet<TodoCustomSelect>();
            TodoNotes = new HashSet<TodoNote>();
            TodoSavedFilters = new HashSet<TodoSavedFilter>();
            TodoStatuses = new HashSet<TodoStatus>();
            TodoUsers = new HashSet<Todo>();
            UserContactForms = new HashSet<UserContactForm>();
            UserDetails = new HashSet<UserDetail>();
            UserDiskUsages = new HashSet<UserDiskUsage>();
            UserSettings = new HashSet<UserSetting>();
            UserTrackings = new HashSet<UserTracking>();
            VactWorkRecs = new HashSet<VactWorkRec>();
            WebJobs = new HashSet<WebJob>();
            WorkRecords = new HashSet<WorkRecord>();
        }

        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public bool? Disable { get; set; }
        public string ProviderId { get; set; }
        public Guid ApiUserId { get; set; }
        public DateTime? DateRegistered { get; set; }
        public int? OrganisationId { get; set; }
        public string ProviderIdSecond { get; set; }
        public string ProviderIdThird { get; set; }
        public bool FreeUser { get; set; }

        public virtual Organisation Organisation { get; set; }
        public virtual UserProvider UserProvider { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<ActivityType> ActivityTypes { get; set; }
        public virtual ICollection<AnnouncementEmailUnsubscriber> AnnouncementEmailUnsubscribers { get; set; }
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual ICollection<AutoResponder> AutoResponders { get; set; }
        public virtual ICollection<Campaign> Campaigns { get; set; }
        public virtual ICollection<Cat> Cats { get; set; }
        public virtual ICollection<Checklist> Checklists { get; set; }
        public virtual ICollection<ContactAndList> ContactAndLists { get; set; }
        public virtual ICollection<ContactFile> ContactFiles { get; set; }
        public virtual ICollection<ContactNote> ContactNotes { get; set; }
        public virtual ICollection<ContactProcessStage> ContactProcessStages { get; set; }
        public virtual ICollection<ContactProcessStep> ContactProcessSteps { get; set; }
        public virtual ICollection<ContactTitle> ContactTitles { get; set; }
        public virtual ICollection<ContactToDoField> ContactToDoFields { get; set; }
        public virtual ICollection<ContactType> ContactTypes { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<CountUpTimer> CountUpTimers { get; set; }
        public virtual ICollection<Country> Countries { get; set; }
        public virtual ICollection<DeletedContact> DeletedContacts { get; set; }
        public virtual ICollection<DynamicLabel> DynamicLabels { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<Followup> Followups { get; set; }
        public virtual ICollection<Gdprconsent> Gdprconsents { get; set; }
        public virtual ICollection<GoalWin> GoalWins { get; set; }
        public virtual ICollection<Goal> Goals { get; set; }
        public virtual ICollection<GoogleToken> GoogleTokens { get; set; }
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
        public virtual ICollection<InvoicePayment> InvoicePayments { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<JobHeader> JobHeaders { get; set; }
        public virtual ICollection<JobItem> JobItems { get; set; }
        public virtual ICollection<JobNote> JobNotes { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<LessonCompleted> LessonCompleteds { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual ICollection<MailchimpCampaign> MailchimpCampaigns { get; set; }
        public virtual ICollection<MarketingList> MarketingLists { get; set; }
        public virtual ICollection<MyNote> MyNotes { get; set; }
        public virtual ICollection<MySetting> MySettings { get; set; }
        public virtual ICollection<Opportunity> Opportunities { get; set; }
        public virtual ICollection<OpportunityStageHistory> OpportunityStageHistories { get; set; }
        public virtual ICollection<OpportunityStage> OpportunityStages { get; set; }
        public virtual ICollection<Org> OrgAccountManagers { get; set; }
        public virtual ICollection<OrgCustomSelect> OrgCustomSelects { get; set; }
        public virtual ICollection<OrgSavedFilter> OrgSavedFilters { get; set; }
        public virtual ICollection<OrgTodoType> OrgTodoTypes { get; set; }
        public virtual ICollection<Org> OrgUsers { get; set; }
        public virtual ICollection<OutlookIntegration> OutlookIntegrations { get; set; }
        public virtual ICollection<ProcessStep> ProcessSteps { get; set; }
        public virtual ICollection<Process> Processes { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProjectNote> ProjectNotes { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<QuickNote> QuickNotes { get; set; }
        public virtual ICollection<Quote> QuoteAssignedUsers { get; set; }
        public virtual ICollection<QuoteItem> QuoteItems { get; set; }
        public virtual ICollection<Quote> QuoteUsers { get; set; }
        public virtual ICollection<QuotesSavedFilter> QuotesSavedFilters { get; set; }
        public virtual ICollection<RitualDay> RitualDays { get; set; }
        public virtual ICollection<Ritual> Rituals { get; set; }
        public virtual ICollection<SalesProcess> SalesProcesses { get; set; }
        public virtual ICollection<SalesStepGroup> SalesStepGroups { get; set; }
        public virtual ICollection<SalesStep> SalesSteps { get; set; }
        public virtual ICollection<SkypeCall> SkypeCalls { get; set; }
        public virtual ICollection<Source> Sources { get; set; }
        public virtual ICollection<SubjectUser> SubjectUsers { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<SystemEmailSubscription> SystemEmailSubscriptions { get; set; }
        public virtual ICollection<TemplateType> TemplateTypes { get; set; }
        public virtual ICollection<Template> Templates { get; set; }
        public virtual ICollection<Todo> TodoAssignedUsers { get; set; }
        public virtual ICollection<TodoCategory> TodoCategories { get; set; }
        public virtual ICollection<TodoCustomSelect> TodoCustomSelects { get; set; }
        public virtual ICollection<TodoNote> TodoNotes { get; set; }
        public virtual ICollection<TodoSavedFilter> TodoSavedFilters { get; set; }
        public virtual ICollection<TodoStatus> TodoStatuses { get; set; }
        public virtual ICollection<Todo> TodoUsers { get; set; }
        public virtual ICollection<UserContactForm> UserContactForms { get; set; }
        public virtual ICollection<UserDetail> UserDetails { get; set; }
        public virtual ICollection<UserDiskUsage> UserDiskUsages { get; set; }
        public virtual ICollection<UserSetting> UserSettings { get; set; }
        public virtual ICollection<UserTracking> UserTrackings { get; set; }
        public virtual ICollection<VactWorkRec> VactWorkRecs { get; set; }
        public virtual ICollection<WebJob> WebJobs { get; set; }
        public virtual ICollection<WorkRecord> WorkRecords { get; set; }
    }
}
