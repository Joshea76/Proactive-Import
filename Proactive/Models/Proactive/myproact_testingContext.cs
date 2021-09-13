using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class myproact_testingContext : DbContext
    {
        public myproact_testingContext()
        {
        }

        public myproact_testingContext(DbContextOptions<myproact_testingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActionContact> ActionContacts { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<ActivityType> ActivityTypes { get; set; }
        public virtual DbSet<AnnouncementEmail> AnnouncementEmails { get; set; }
        public virtual DbSet<AnnouncementEmailUnsubscriber> AnnouncementEmailUnsubscribers { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AutoResponder> AutoResponders { get; set; }
        public virtual DbSet<AutoResponderCustomer> AutoResponderCustomers { get; set; }
        public virtual DbSet<AutoResponderEmail> AutoResponderEmails { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<Cat> Cats { get; set; }
        public virtual DbSet<Checklist> Checklists { get; set; }
        public virtual DbSet<ChecklistContact> ChecklistContacts { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactAndList> ContactAndLists { get; set; }
        public virtual DbSet<ContactFile> ContactFiles { get; set; }
        public virtual DbSet<ContactNote> ContactNotes { get; set; }
        public virtual DbSet<ContactProcessStage> ContactProcessStages { get; set; }
        public virtual DbSet<ContactProcessStep> ContactProcessSteps { get; set; }
        public virtual DbSet<ContactSalesStep> ContactSalesSteps { get; set; }
        public virtual DbSet<ContactTitle> ContactTitles { get; set; }
        public virtual DbSet<ContactToDoField> ContactToDoFields { get; set; }
        public virtual DbSet<ContactToDoFieldValue> ContactToDoFieldValues { get; set; }
        public virtual DbSet<ContactType> ContactTypes { get; set; }
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<CountUpTimer> CountUpTimers { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Day> Days { get; set; }
        public virtual DbSet<DeletedContact> DeletedContacts { get; set; }
        public virtual DbSet<DomainActivity> DomainActivities { get; set; }
        public virtual DbSet<DtoContactName> DtoContactNames { get; set; }
        public virtual DbSet<DynamicLabel> DynamicLabels { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<EmailFooter> EmailFooters { get; set; }
        public virtual DbSet<Followup> Followups { get; set; }
        public virtual DbSet<Gdprconsent> Gdprconsents { get; set; }
        public virtual DbSet<GlobalSetting> GlobalSettings { get; set; }
        public virtual DbSet<Goal> Goals { get; set; }
        public virtual DbSet<GoalWin> GoalWins { get; set; }
        public virtual DbSet<GoogleToken> GoogleTokens { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceItem> InvoiceItems { get; set; }
        public virtual DbSet<InvoicePayment> InvoicePayments { get; set; }
        public virtual DbSet<InvoicePdf> InvoicePdfs { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobHeader> JobHeaders { get; set; }
        public virtual DbSet<JobItem> JobItems { get; set; }
        public virtual DbSet<JobNote> JobNotes { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<LessonCompleted> LessonCompleteds { get; set; }
        public virtual DbSet<MailchimpCampaign> MailchimpCampaigns { get; set; }
        public virtual DbSet<MarketingList> MarketingLists { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<MyNote> MyNotes { get; set; }
        public virtual DbSet<MySetting> MySettings { get; set; }
        public virtual DbSet<Opportunity> Opportunities { get; set; }
        public virtual DbSet<OpportunityStage> OpportunityStages { get; set; }
        public virtual DbSet<OpportunityStageHistory> OpportunityStageHistories { get; set; }
        public virtual DbSet<Org> Orgs { get; set; }
        public virtual DbSet<OrgCustomSelect> OrgCustomSelects { get; set; }
        public virtual DbSet<OrgCustomSelectItem> OrgCustomSelectItems { get; set; }
        public virtual DbSet<OrgCustomSelectValue> OrgCustomSelectValues { get; set; }
        public virtual DbSet<OrgSavedFilter> OrgSavedFilters { get; set; }
        public virtual DbSet<OrgSavedFilterCustomField> OrgSavedFilterCustomFields { get; set; }
        public virtual DbSet<OrgTodoType> OrgTodoTypes { get; set; }
        public virtual DbSet<Organisation> Organisations { get; set; }
        public virtual DbSet<OutlookIntegration> OutlookIntegrations { get; set; }
        public virtual DbSet<PayPalLog> PayPalLogs { get; set; }
        public virtual DbSet<PayPalTransaction> PayPalTransactions { get; set; }
        public virtual DbSet<PresetUserDatum> PresetUserData { get; set; }
        public virtual DbSet<Process> Processes { get; set; }
        public virtual DbSet<ProcessContact> ProcessContacts { get; set; }
        public virtual DbSet<ProcessStep> ProcessSteps { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectNote> ProjectNotes { get; set; }
        public virtual DbSet<ProviderPayment> ProviderPayments { get; set; }
        public virtual DbSet<QuickNote> QuickNotes { get; set; }
        public virtual DbSet<Quote> Quotes { get; set; }
        public virtual DbSet<QuoteItem> QuoteItems { get; set; }
        public virtual DbSet<QuotesSavedFilter> QuotesSavedFilters { get; set; }
        public virtual DbSet<Ritual> Rituals { get; set; }
        public virtual DbSet<RitualDay> RitualDays { get; set; }
        public virtual DbSet<SalesProcess> SalesProcesses { get; set; }
        public virtual DbSet<SalesStep> SalesSteps { get; set; }
        public virtual DbSet<SalesStepGroup> SalesStepGroups { get; set; }
        public virtual DbSet<SamTest> SamTests { get; set; }
        public virtual DbSet<SetActivityType> SetActivityTypes { get; set; }
        public virtual DbSet<SkypeCall> SkypeCalls { get; set; }
        public virtual DbSet<Source> Sources { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<SubjectUser> SubjectUsers { get; set; }
        public virtual DbSet<SubscriptionReminderEmail> SubscriptionReminderEmails { get; set; }
        public virtual DbSet<SystemEmail> SystemEmails { get; set; }
        public virtual DbSet<SystemEmailSubscription> SystemEmailSubscriptions { get; set; }
        public virtual DbSet<Template> Templates { get; set; }
        public virtual DbSet<TemplateType> TemplateTypes { get; set; }
        public virtual DbSet<TermsAndCondition> TermsAndConditions { get; set; }
        public virtual DbSet<TimePeriod> TimePeriods { get; set; }
        public virtual DbSet<Todo> Todoes { get; set; }
        public virtual DbSet<TodoCategory> TodoCategories { get; set; }
        public virtual DbSet<TodoCustomSelect> TodoCustomSelects { get; set; }
        public virtual DbSet<TodoCustomSelectItem> TodoCustomSelectItems { get; set; }
        public virtual DbSet<TodoCustomSelectValue> TodoCustomSelectValues { get; set; }
        public virtual DbSet<TodoNote> TodoNotes { get; set; }
        public virtual DbSet<TodoSavedFilter> TodoSavedFilters { get; set; }
        public virtual DbSet<TodoSavedFilterCustomField> TodoSavedFilterCustomFields { get; set; }
        public virtual DbSet<TodoStatus> TodoStatuses { get; set; }
        public virtual DbSet<UserContactForm> UserContactForms { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public virtual DbSet<UserDiskUsage> UserDiskUsages { get; set; }
        public virtual DbSet<UserOnBoardDoneTask> UserOnBoardDoneTasks { get; set; }
        public virtual DbSet<UserOnBoardTask> UserOnBoardTasks { get; set; }
        public virtual DbSet<UserProvider> UserProviders { get; set; }
        public virtual DbSet<UserSetting> UserSettings { get; set; }
        public virtual DbSet<UserTracking> UserTrackings { get; set; }
        public virtual DbSet<VactWorkRec> VactWorkRecs { get; set; }
        public virtual DbSet<ViewContactsList> ViewContactsLists { get; set; }
        public virtual DbSet<WebJob> WebJobs { get; set; }
        public virtual DbSet<WorkRecord> WorkRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=sql11.hostinguk.net;Database=myproact_testing;User ID=myproact_testing;Password=V_dh7h44;Trusted_Connection=False;Encrypt=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("myproact_testing")
                .HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<ActionContact>(entity =>
            {
                entity.ToTable("ActionContacts", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.ToTable("Activities", "dbo");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EmailFolder).HasMaxLength(512);

                entity.Property(e => e.EmailId).HasColumnName("EmailID");

                entity.Property(e => e.ExternalEmailId).HasMaxLength(512);

                entity.Property(e => e.MailchimpCampaignId).HasColumnName("MailchimpCampaignID");

                entity.Property(e => e.OpportunityId).HasColumnName("OpportunityID");

                entity.Property(e => e.SalesProcessId).HasColumnName("SalesProcessID");

                entity.Property(e => e.SalesStepId).HasColumnName("SalesStepID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.ActivityType)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.ActivityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Activities_dbo.ActivityTypes_ActivityTypeID");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_dbo.Activities_dbo.Contacts_ContactID");

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.EmailId)
                    .HasConstraintName("FK_dbo.Activities_dbo.Emails_EmailID");

                entity.HasOne(d => d.MailchimpCampaign)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.MailchimpCampaignId)
                    .HasConstraintName("FK_dbo.Activities_dbo.MailchimpCampaigns_MailchimpCampaignID");

                entity.HasOne(d => d.Opportunity)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.OpportunityId)
                    .HasConstraintName("FK_dbo.Activities_dbo.Opportunities_OpportunityID");

                entity.HasOne(d => d.SalesProcess)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.SalesProcessId)
                    .HasConstraintName("FK_dbo.Contacts_dbo.SalesProcesses_ID");

                entity.HasOne(d => d.SalesStep)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.SalesStepId)
                    .HasConstraintName("FK_dbo.Activities_dbo.SalesStep_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Activities_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<ActivityType>(entity =>
            {
                entity.ToTable("ActivityTypes", "dbo");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.ActivityName).IsRequired();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ActivityTypes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ActivityTypes_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<AnnouncementEmail>(entity =>
            {
                entity.ToTable("AnnouncementEmails", "dbo");

                entity.Property(e => e.AnnouncementEmailId).HasColumnName("AnnouncementEmailID");

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(512);
            });

            modelBuilder.Entity<AnnouncementEmailUnsubscriber>(entity =>
            {
                entity.ToTable("AnnouncementEmailUnsubscribers", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.AnnouncementEmailUnsubscriberId).HasColumnName("AnnouncementEmailUnsubscriberID");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AnnouncementEmailUnsubscribers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AnnouncementEmailUnsubscribers_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.ToTable("AspNetRoles", "dbo");

                entity.HasIndex(e => e.Name, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.ToTable("AspNetUsers", "dbo");

                entity.HasIndex(e => e.OrganisationId, "IX_OrganisationID");

                entity.HasIndex(e => e.UserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.ApiUserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateRegistered).HasColumnType("datetime");

                entity.Property(e => e.Disable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.ProviderId).HasMaxLength(128);

                entity.Property(e => e.ProviderIdSecond).HasMaxLength(50);

                entity.Property(e => e.ProviderIdThird).HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.OrganisationId)
                    .HasConstraintName("FK_dbo.AspNetUsers_dbo.Organisations_OrganisationID");
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.ToTable("AspNetUserClaims", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.ToTable("AspNetUserLogins", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.ToTable("AspNetUserRoles", "dbo");

                entity.HasIndex(e => e.RoleId, "IX_RoleId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AutoResponder>(entity =>
            {
                entity.HasKey(e => e.CampaignId)
                    .HasName("PK_dbo.AutoResponders");

                entity.ToTable("AutoResponders", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AutoResponders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Campaigns_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AutoResponderCustomer>(entity =>
            {
                entity.HasKey(e => e.CampaignCustomerId)
                    .HasName("PK_dbo.AutoResponderCustomers");

                entity.ToTable("AutoResponderCustomers", "dbo");

                entity.HasIndex(e => e.CampaignId, "IX_CampaignId");

                entity.Property(e => e.DateOptedIn).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress).IsRequired();

                entity.Property(e => e.FirstName).IsRequired();

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.AutoResponderCustomers)
                    .HasForeignKey(d => d.CampaignId)
                    .HasConstraintName("FK_dbo.CampaignCustomers_dbo.Campaigns_CampaignId");
            });

            modelBuilder.Entity<AutoResponderEmail>(entity =>
            {
                entity.HasKey(e => e.CampaignEmailId)
                    .HasName("PK_dbo.AutoResponderEmails");

                entity.ToTable("AutoResponderEmails", "dbo");

                entity.HasIndex(e => e.CampaignId, "IX_CampaignId");

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.SubjectLine).IsRequired();

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.AutoResponderEmails)
                    .HasForeignKey(d => d.CampaignId)
                    .HasConstraintName("FK_dbo.CampaignEmails_dbo.Campaigns_CampaignId");
            });

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.ToTable("Blogs", "dbo");

                entity.Property(e => e.BlogId).HasColumnName("BlogID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DatePublished).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Title).IsRequired();

                entity.Property(e => e.VideoUrl).HasColumnName("VideoURL");
            });

            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.ToTable("Campaigns", "dbo");

                entity.HasIndex(e => e.MarketingListId, "IX_MarketingListId");

                entity.HasIndex(e => e.UserId, "IX_User_ID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(128)
                    .HasColumnName("User_ID");

                entity.HasOne(d => d.MarketingList)
                    .WithMany(p => p.Campaigns)
                    .HasForeignKey(d => d.MarketingListId)
                    .HasConstraintName("FK_dbo.Campaigns_dbo.MarketingLists_MarketingListId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Campaigns)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Campaigns_dbo.AspNetUsers_User_ID");
            });

            modelBuilder.Entity<Cat>(entity =>
            {
                entity.ToTable("Cats", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Cats)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Cats_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<Checklist>(entity =>
            {
                entity.ToTable("Checklists", "dbo");

                entity.Property(e => e.ChecklistId).HasColumnName("ChecklistID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2048);

                entity.Property(e => e.DoByDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Checklists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Checklists_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<ChecklistContact>(entity =>
            {
                entity.HasKey(e => new { e.ChecklistId, e.ContactId })
                    .HasName("PK_dbo.ChecklistContacts");

                entity.ToTable("ChecklistContacts", "dbo");

                entity.Property(e => e.ChecklistId).HasColumnName("ChecklistID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.Note).HasMaxLength(2048);

                entity.HasOne(d => d.Checklist)
                    .WithMany(p => p.ChecklistContacts)
                    .HasForeignKey(d => d.ChecklistId)
                    .HasConstraintName("FK_dbo.ChecklistContacts_dbo.Checklists_ChecklistID");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ChecklistContacts)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_dbo.ChecklistContacts_dbo.Contacts_ContactID");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contacts", "dbo");

                entity.HasIndex(e => e.ContactTitleId, "IX_ContactTitleID");

                entity.HasIndex(e => e.ContactTypeId, "IX_ContactTypeID");

                entity.HasIndex(e => e.CountryId, "IX_CountryID");

                entity.HasIndex(e => e.OrgId, "IX_OrgID");

                entity.HasIndex(e => e.OrgOrgId, "IX_Org_OrgID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(128);

                entity.Property(e => e.ContactTitleId).HasColumnName("ContactTitleID");

                entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(128);

                entity.Property(e => e.FamilyName).HasMaxLength(128);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.GivenName).HasMaxLength(128);

                entity.Property(e => e.Industry).HasMaxLength(250);

                entity.Property(e => e.JobTitle).HasMaxLength(128);

                entity.Property(e => e.MlistId).HasColumnName("MListID");

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.Property(e => e.OrgOrgId).HasColumnName("Org_OrgID");

                entity.Property(e => e.PhotoUrl).HasMaxLength(2048);

                entity.Property(e => e.SalesProcessId).HasColumnName("SalesProcessID");

                entity.Property(e => e.SkypeId).HasColumnName("SkypeID");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.ContactTitle)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.ContactTitleId)
                    .HasConstraintName("FK_dbo.Contacts_dbo.ContactTitles_ContactTitleID");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.ContactTypeId)
                    .HasConstraintName("FK_dbo.Contacts_dbo.ContactTypes_ContactTypeID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_dbo.Contacts_dbo.Countries_CountryID");

                entity.HasOne(d => d.CurrentSalesStepNavigation)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.CurrentSalesStep)
                    .HasConstraintName("FK_dbo.Contacts_dbo.SalesSteps_ID");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.ContactOrgs)
                    .HasForeignKey(d => d.OrgId)
                    .HasConstraintName("FK_dbo.Contacts_dbo.Orgs_Org_OrgID1");

                entity.HasOne(d => d.OrgOrg)
                    .WithMany(p => p.ContactOrgOrgs)
                    .HasForeignKey(d => d.OrgOrgId)
                    .HasConstraintName("FK_dbo.Contacts_dbo.Orgs_Org_OrgID");

                entity.HasOne(d => d.SalesProcess)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.SalesProcessId)
                    .HasConstraintName("FK_dbo.Contacts_dbo.SalesProcess_ID");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.SourceId)
                    .HasConstraintName("FK_dbo.Contacts_dbo.Sources_SourceID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Contacts_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<ContactAndList>(entity =>
            {
                entity.ToTable("ContactAndLists", "dbo");

                entity.Property(e => e.ContactAndListId).HasColumnName("ContactAndListID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.MarketingListId).HasColumnName("MarketingListID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContactAndLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ContactAndLists_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<ContactFile>(entity =>
            {
                entity.ToTable("ContactFiles", "dbo");

                entity.HasIndex(e => e.ContactId, "IX_ContactID");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.ContactFileId).HasColumnName("ContactFileID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Notes).HasMaxLength(2048);

                entity.Property(e => e.PhysicalFileName)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.UserFileName)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactFiles)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_dbo.ContactFiles_dbo.Contacts_ContactID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContactFiles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ContactFiles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<ContactNote>(entity =>
            {
                entity.ToTable("ContactNotes", "dbo");

                entity.HasIndex(e => e.ContactId, "IX_ContactID");

                entity.HasIndex(e => e.OpportunityId, "IX_OpportunityID");

                entity.HasIndex(e => e.OrgId, "IX_OrgID");

                entity.Property(e => e.ContactNoteId).HasColumnName("ContactNoteID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.OpportunityId).HasColumnName("OpportunityID");

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactNotes)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_dbo.ContactNotes_dbo.Contacts_ContactID");

                entity.HasOne(d => d.Opportunity)
                    .WithMany(p => p.ContactNotes)
                    .HasForeignKey(d => d.OpportunityId)
                    .HasConstraintName("FK_dbo.ContactNotes_dbo.Opportunities_OpportunityID");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.ContactNotes)
                    .HasForeignKey(d => d.OrgId)
                    .HasConstraintName("FK_dbo.ContactNotes_dbo.Orgs_OrgID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContactNotes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ContactNotes_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<ContactProcessStage>(entity =>
            {
                entity.ToTable("ContactProcessStages", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.ContactProcessStageId).HasColumnName("ContactProcessStageID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContactProcessStages)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ContactProcessStages_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<ContactProcessStep>(entity =>
            {
                entity.ToTable("ContactProcessSteps", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.ContactProcessStepId).HasColumnName("ContactProcessStepID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DoBy).HasColumnType("datetime");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.StepId).HasColumnName("StepID");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContactProcessSteps)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ContactProcessSteps_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<ContactSalesStep>(entity =>
            {
                entity.ToTable("ContactSalesSteps", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.SalesProcessId).HasColumnName("SalesProcessID");

                entity.Property(e => e.StepId).HasColumnName("StepID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");
            });

            modelBuilder.Entity<ContactTitle>(entity =>
            {
                entity.ToTable("ContactTitles", "dbo");

                entity.Property(e => e.ContactTitleId).HasColumnName("ContactTitleID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContactTitles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ContactTitles_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<ContactToDoField>(entity =>
            {
                entity.ToTable("ContactToDoFields", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.ContactToDoFieldId).HasColumnName("ContactToDoFieldID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContactToDoFields)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ContactToDoFields_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<ContactToDoFieldValue>(entity =>
            {
                entity.HasKey(e => new { e.ContactId, e.ContactToDoFieldId })
                    .HasName("PK_dbo.ContactToDoFieldValues");

                entity.ToTable("ContactToDoFieldValues", "dbo");

                entity.HasIndex(e => e.ContactId, "IX_ContactID");

                entity.HasIndex(e => e.ContactToDoFieldId, "IX_ContactToDoFieldID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactToDoFieldId).HasColumnName("ContactToDoFieldID");

                entity.Property(e => e.Note).HasMaxLength(2048);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactToDoFieldValues)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_dbo.ContactToDoFieldValues_dbo.Contacts_ContactID");

                entity.HasOne(d => d.ContactToDoField)
                    .WithMany(p => p.ContactToDoFieldValues)
                    .HasForeignKey(d => d.ContactToDoFieldId)
                    .HasConstraintName("FK_dbo.ContactToDoFieldValues_dbo.ContactToDoFields_ContactToDoFieldID");
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.ToTable("ContactTypes", "dbo");

                entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContactTypes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ContactTypes_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.ToTable("Contents", "dbo");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DatePublish).HasColumnType("datetime");

                entity.Property(e => e.Title).IsRequired();
            });

            modelBuilder.Entity<CountUpTimer>(entity =>
            {
                entity.ToTable("CountUpTimers", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.PageReference).IsRequired();

                entity.Property(e => e.Started).HasColumnType("datetime");

                entity.Property(e => e.TimerReference).IsRequired();

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CountUpTimers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.CountUpTimers_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Countries", "dbo");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Countries_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<Day>(entity =>
            {
                entity.ToTable("Days", "dbo");

                entity.Property(e => e.DayId).HasColumnName("DayID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Days)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Days_dbo.Languages_ID");
            });

            modelBuilder.Entity<DeletedContact>(entity =>
            {
                entity.ToTable("DeletedContacts", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.DeletedContactId).HasColumnName("DeletedContactID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DeletedContacts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.DeletedContacts_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<DomainActivity>(entity =>
            {
                entity.ToTable("DomainActivities", "dbo");

                entity.HasIndex(e => e.ContactId, "IX_ContactID");

                entity.HasIndex(e => e.OrgId, "IX_OrgID");

                entity.Property(e => e.DomainActivityId).HasColumnName("DomainActivityID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.DomainActivities)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_dbo.DomainActivities_dbo.Contacts_ContactID");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.DomainActivities)
                    .HasForeignKey(d => d.OrgId)
                    .HasConstraintName("FK_dbo.DomainActivities_dbo.Orgs_OrgID");
            });

            modelBuilder.Entity<DtoContactName>(entity =>
            {
                entity.ToTable("dtoContactNames", "dbo");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");
            });

            modelBuilder.Entity<DynamicLabel>(entity =>
            {
                entity.ToTable("DynamicLabels", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.MiscField1).HasMaxLength(50);

                entity.Property(e => e.MiscField2).HasMaxLength(50);

                entity.Property(e => e.MiscField3).HasMaxLength(50);

                entity.Property(e => e.MiscField4).HasMaxLength(50);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DynamicLabels)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.DynamicLabels_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.ToTable("Emails", "dbo");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Emails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Emails_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<EmailFooter>(entity =>
            {
                entity.ToTable("EmailFooters", "dbo");

                entity.Property(e => e.FooterText)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Followup>(entity =>
            {
                entity.ToTable("Followups", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.FollowupId).HasColumnName("FollowupID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ListId).HasColumnName("ListID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Followups)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Followups_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<Gdprconsent>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("PK_dbo.GDPRConsents");

                entity.ToTable("GDPRConsents", "dbo");

                entity.HasIndex(e => e.ContactId, "IX_ContactID");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.ContactId)
                    .ValueGeneratedNever()
                    .HasColumnName("ContactID");

                entity.Property(e => e.DateGiven).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Contact)
                    .WithOne(p => p.Gdprconsent)
                    .HasForeignKey<Gdprconsent>(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.GDPRConsents_dbo.Contacts_ContactID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Gdprconsents)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.GDPRConsents_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<GlobalSetting>(entity =>
            {
                entity.ToTable("GlobalSettings", "dbo");

                entity.Property(e => e.GlobalSettingId).HasColumnName("GlobalSettingID");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Value).HasMaxLength(4000);
            });

            modelBuilder.Entity<Goal>(entity =>
            {
                entity.ToTable("Goals", "dbo");

                entity.Property(e => e.GoalId).HasColumnName("GoalID");

                entity.Property(e => e.AchieveByDate).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DoneDate).HasColumnType("datetime");

                entity.Property(e => e.GoalDesc).IsRequired();

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Goals)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Goals_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<GoalWin>(entity =>
            {
                entity.ToTable("GoalWins", "dbo");

                entity.HasIndex(e => e.GoalId, "IX_GoalID");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.GoalWinId).HasColumnName("GoalWinID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.GoalId).HasColumnName("GoalID");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Goal)
                    .WithMany(p => p.GoalWins)
                    .HasForeignKey(d => d.GoalId)
                    .HasConstraintName("FK_dbo.GoalWins_dbo.Goals_GoalID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GoalWins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.GoalWins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<GoogleToken>(entity =>
            {
                entity.ToTable("GoogleTokens", "dbo");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GoogleTokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.GoogleTokens_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("Invoices", "dbo");

                entity.HasIndex(e => e.ContactId, "IX_ContactID");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactNote).HasMaxLength(1024);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DatePaid).HasColumnType("datetime");

                entity.Property(e => e.DatePaymentDue).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.MyNote).HasMaxLength(1024);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.VatRate).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_dbo.Invoices_dbo.Contacts_ContactID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Invoices_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<InvoiceItem>(entity =>
            {
                entity.ToTable("InvoiceItems", "dbo");

                entity.HasIndex(e => e.InvoiceId, "IX_InvoiceID");

                entity.HasIndex(e => e.ProductId, "IX_ProductID");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.InvoiceItemId).HasColumnName("InvoiceItemID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceItems)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_dbo.InvoiceItems_dbo.Invoices_InvoiceID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.InvoiceItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.InvoiceItems_dbo.Products_ProductID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.InvoiceItems)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.InvoiceItems_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<InvoicePayment>(entity =>
            {
                entity.ToTable("InvoicePayments", "dbo");

                entity.HasIndex(e => e.InvoiceId, "IX_InvoiceId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoicePayments)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_dbo.InvoicePayments_dbo.Invoices_InvoiceId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.InvoicePayments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.InvoicePayments_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<InvoicePdf>(entity =>
            {
                entity.HasKey(e => e.JobHeaderId)
                    .HasName("PK_dbo.InvoicePDFs");

                entity.ToTable("InvoicePDFs", "dbo");

                entity.Property(e => e.JobHeaderId).HasColumnName("JobHeaderID");

                entity.Property(e => e.ContactCountryId)
                    .HasColumnName("ContactCountryID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.DatePdfcreated)
                    .HasColumnType("datetime")
                    .HasColumnName("DatePDFCreated");

                entity.Property(e => e.ImageUrl).HasColumnName("ImageURL");

                entity.Property(e => e.OrgId)
                    .HasColumnName("OrgID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentDue).HasColumnType("datetime");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Jobs", "dbo");

                entity.HasIndex(e => e.JobHeaderId, "IX_JobHeaderID");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.DateCompleted).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDoneBy).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.JobHeaderId).HasColumnName("JobHeaderID");

                entity.Property(e => e.TempContactId).HasColumnName("TempContactID");

                entity.Property(e => e.TempJobheaderId).HasColumnName("TempJobheaderID");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.JobHeader)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.JobHeaderId)
                    .HasConstraintName("FK_dbo.Jobs_dbo.JobHeaders_JobHeaderID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Jobs_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<JobHeader>(entity =>
            {
                entity.ToTable("JobHeaders", "dbo");

                entity.HasIndex(e => e.ContactId, "IX_ContactID");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.JobHeaderId).HasColumnName("JobHeaderID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactNote).HasMaxLength(1024);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.PaymentDue).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.JobHeaders)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_dbo.JobHeaders_dbo.Contacts_ContactID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JobHeaders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.JobHeaders_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<JobItem>(entity =>
            {
                entity.ToTable("JobItems", "dbo");

                entity.HasIndex(e => e.JobHeaderId, "IX_JobHeaderID");

                entity.HasIndex(e => e.JobJobId, "IX_Job_JobID");

                entity.HasIndex(e => e.ProductId, "IX_ProductID");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.JobItemId).HasColumnName("JobItemID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDone).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.DoByDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceIdtemp).HasColumnName("InvoiceIDTemp");

                entity.Property(e => e.JobHeaderId).HasColumnName("JobHeaderID");

                entity.Property(e => e.JobJobId).HasColumnName("Job_JobID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TempjobId).HasColumnName("TEMPJobID");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.JobHeader)
                    .WithMany(p => p.JobItems)
                    .HasForeignKey(d => d.JobHeaderId)
                    .HasConstraintName("FK_dbo.JobItems_dbo.JobHeaders_JobHeaderID");

                entity.HasOne(d => d.JobJob)
                    .WithMany(p => p.JobItems)
                    .HasForeignKey(d => d.JobJobId)
                    .HasConstraintName("FK_dbo.JobItems_dbo.Jobs_Job_JobID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.JobItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.JobItems_dbo.Products_ProductID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JobItems)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.JobItems_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<JobNote>(entity =>
            {
                entity.ToTable("JobNotes", "dbo");

                entity.HasIndex(e => e.JobId, "IX_JobID");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.JobNoteId).HasColumnName("JobNoteID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DoBy).HasColumnType("datetime");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.Note).IsRequired();

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobNotes)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_dbo.JobNotes_dbo.Jobs_JobID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JobNotes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.JobNotes_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasKey(e => e.LanguagesId)
                    .HasName("PK_dbo.Languages");

                entity.ToTable("Languages", "dbo");

                entity.Property(e => e.LanguagesId).HasColumnName("LanguagesID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.ToTable("Lessons", "dbo");

                entity.HasIndex(e => e.SubjectId, "IX_SubjectID");

                entity.Property(e => e.LessonId).HasColumnName("LessonID");

                entity.Property(e => e.DateAdded).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LessonTitle)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.Lessons_dbo.Subjects_SubjectID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Lessons_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<LessonCompleted>(entity =>
            {
                entity.ToTable("LessonCompleteds", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.LessonCompletedId).HasColumnName("LessonCompletedID");

                entity.Property(e => e.DateCompleted).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LessonCompleteds)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.LessonCompleteds_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<MailchimpCampaign>(entity =>
            {
                entity.ToTable("MailchimpCampaigns", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.MailchimpCampaignId).HasColumnName("MailchimpCampaignID");

                entity.Property(e => e.CampaignId)
                    .HasMaxLength(512)
                    .HasColumnName("CampaignID");

                entity.Property(e => e.CampaignTitle).HasMaxLength(512);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ListId)
                    .HasMaxLength(512)
                    .HasColumnName("ListID");

                entity.Property(e => e.ListTitle).HasMaxLength(512);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MailchimpCampaigns)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.MailchimpCampaigns_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<MarketingList>(entity =>
            {
                entity.ToTable("MarketingLists", "dbo");

                entity.HasIndex(e => e.ContactAndListId, "IX_ContactAndListID");

                entity.Property(e => e.MarketingListId).HasColumnName("MarketingListID");

                entity.Property(e => e.ContactAndListId).HasColumnName("ContactAndListID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ListName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.ContactAndList)
                    .WithMany(p => p.MarketingLists)
                    .HasForeignKey(d => d.ContactAndListId)
                    .HasConstraintName("FK_dbo.MarketingLists_dbo.ContactAndLists_ContactAndListID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MarketingLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.MarketingLists_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory", "dbo");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<MyNote>(entity =>
            {
                entity.ToTable("MyNotes", "dbo");

                entity.Property(e => e.MyNoteId).HasColumnName("MyNoteID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Tags).HasMaxLength(150);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Note Title')");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MyNotes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.MyNotes_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<MySetting>(entity =>
            {
                entity.HasKey(e => e.MySettingsId)
                    .HasName("PK_dbo.MySettings");

                entity.ToTable("MySettings", "dbo");

                entity.Property(e => e.MySettingsId).HasColumnName("mySettingsID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MySettings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.MySettings_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<Opportunity>(entity =>
            {
                entity.ToTable("Opportunities", "dbo");

                entity.HasIndex(e => e.ContactId, "IX_ContactID");

                entity.HasIndex(e => e.OpportunityStageId, "IX_OpportunityStageID");

                entity.HasIndex(e => e.ProductId, "IX_ProductID");

                entity.Property(e => e.OpportunityId).HasColumnName("OpportunityID");

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.OpportunityStageId).HasColumnName("OpportunityStageID");

                entity.Property(e => e.OpportunityValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Opportunities)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_dbo.Opportunities_dbo.Contacts_ContactID");

                entity.HasOne(d => d.OpportunityStage)
                    .WithMany(p => p.Opportunities)
                    .HasForeignKey(d => d.OpportunityStageId)
                    .HasConstraintName("FK_dbo.Opportunities_dbo.OpportunityStages_OpportunityStageID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Opportunities)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.Opportunities_dbo.Products_ProductID");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.Opportunities)
                    .HasForeignKey(d => d.SourceId)
                    .HasConstraintName("FK_dbo.Opportunities_dbo.Sources_SourceID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Opportunities)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Opportunities_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<OpportunityStage>(entity =>
            {
                entity.ToTable("OpportunityStages", "dbo");

                entity.Property(e => e.OpportunityStageId).HasColumnName("OpportunityStageID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.OpportunityStageName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OpportunityStages)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.OpportunityStages_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<OpportunityStageHistory>(entity =>
            {
                entity.ToTable("OpportunityStageHistories", "dbo");

                entity.HasIndex(e => e.ContactId, "IX_ContactID");

                entity.HasIndex(e => e.EndStageId, "IX_EndStageID");

                entity.HasIndex(e => e.OpportunityId, "IX_OpportunityID");

                entity.HasIndex(e => e.StartStageId, "IX_StartStageID");

                entity.HasIndex(e => e.UserId, "IX_UserID");

                entity.Property(e => e.OpportunityStageHistoryId).HasColumnName("OpportunityStageHistoryID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.DateOfChange).HasColumnType("datetime");

                entity.Property(e => e.EndStageId).HasColumnName("EndStageID");

                entity.Property(e => e.OpportunityId).HasColumnName("OpportunityID");

                entity.Property(e => e.StartStageId).HasColumnName("StartStageID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(128)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.OpportunityStageHistories)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.OpportunityStageHistories_dbo.Contacts_ContactID");

                entity.HasOne(d => d.EndStage)
                    .WithMany(p => p.OpportunityStageHistoryEndStages)
                    .HasForeignKey(d => d.EndStageId)
                    .HasConstraintName("FK_dbo.OpportunityStageHistories_dbo.OpportunityStages_EndStageID");

                entity.HasOne(d => d.Opportunity)
                    .WithMany(p => p.OpportunityStageHistories)
                    .HasForeignKey(d => d.OpportunityId)
                    .HasConstraintName("FK_dbo.OpportunityStageHistories_dbo.Opportunities_OpportunityID");

                entity.HasOne(d => d.StartStage)
                    .WithMany(p => p.OpportunityStageHistoryStartStages)
                    .HasForeignKey(d => d.StartStageId)
                    .HasConstraintName("FK_dbo.OpportunityStageHistories_dbo.OpportunityStages_StartStageID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OpportunityStageHistories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.OpportunityStageHistories_dbo.AspNetUsers_UserID");
            });

            modelBuilder.Entity<Org>(entity =>
            {
                entity.ToTable("Orgs", "dbo");

                entity.HasIndex(e => e.AccountManagerId, "IX_AccountManagerID");

                entity.HasIndex(e => e.BillableContactId, "IX_BillableContactID");

                entity.HasIndex(e => e.BillableCountryId, "IX_BillableCountryID");

                entity.HasIndex(e => e.CountryCountryId, "IX_Country_CountryID");

                entity.HasIndex(e => e.MainContactId, "IX_MainContactID");

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.Property(e => e.AccountManagerId)
                    .HasMaxLength(128)
                    .HasColumnName("AccountManagerID");

                entity.Property(e => e.BillableContactId).HasColumnName("BillableContactID");

                entity.Property(e => e.BillableCountryId).HasColumnName("BillableCountryID");

                entity.Property(e => e.CountryCountryId).HasColumnName("Country_CountryID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.MainContactId).HasColumnName("MainContactID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.AccountManager)
                    .WithMany(p => p.OrgAccountManagers)
                    .HasForeignKey(d => d.AccountManagerId)
                    .HasConstraintName("FK_dbo.Orgs_dbo.AspNetUsers_AccountManager_Id");

                entity.HasOne(d => d.BillableContact)
                    .WithMany(p => p.OrgBillableContacts)
                    .HasForeignKey(d => d.BillableContactId)
                    .HasConstraintName("FK_dbo.Orgs_dbo.Contacts_BillableContactID");

                entity.HasOne(d => d.BillableCountry)
                    .WithMany(p => p.OrgBillableCountries)
                    .HasForeignKey(d => d.BillableCountryId)
                    .HasConstraintName("FK_dbo.Orgs_dbo.Countries_BillableCountryID");

                entity.HasOne(d => d.CountryCountry)
                    .WithMany(p => p.OrgCountryCountries)
                    .HasForeignKey(d => d.CountryCountryId)
                    .HasConstraintName("FK_dbo.Orgs_dbo.Countries_Country_CountryID");

                entity.HasOne(d => d.MainContact)
                    .WithMany(p => p.OrgMainContacts)
                    .HasForeignKey(d => d.MainContactId)
                    .HasConstraintName("FK_dbo.Orgs_dbo.Contacts_MainContact_ContactID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrgUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Orgs_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<OrgCustomSelect>(entity =>
            {
                entity.ToTable("OrgCustomSelects", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrgCustomSelects)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.OrgCustomSelects_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<OrgCustomSelectItem>(entity =>
            {
                entity.ToTable("OrgCustomSelectItems", "dbo");

                entity.HasIndex(e => e.SelectId, "IX_SelectId");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Select)
                    .WithMany(p => p.OrgCustomSelectItems)
                    .HasForeignKey(d => d.SelectId)
                    .HasConstraintName("FK_dbo.OrgCustomSelectItems_dbo.OrgCustomSelects_SelectId");
            });

            modelBuilder.Entity<OrgCustomSelectValue>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.SelectItemId })
                    .HasName("PK_dbo.OrgCustomSelectValues");

                entity.ToTable("OrgCustomSelectValues", "dbo");

                entity.HasIndex(e => e.OrgId, "IX_OrgId");

                entity.HasIndex(e => e.SelectItemId, "IX_SelectItemId");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.OrgCustomSelectValues)
                    .HasForeignKey(d => d.OrgId)
                    .HasConstraintName("FK_dbo.OrgCustomSelectValues_dbo.Orgs_OrgId");

                entity.HasOne(d => d.SelectItem)
                    .WithMany(p => p.OrgCustomSelectValues)
                    .HasForeignKey(d => d.SelectItemId)
                    .HasConstraintName("FK_dbo.OrgCustomSelectValues_dbo.OrgCustomSelectItems_SelectItemId");
            });

            modelBuilder.Entity<OrgSavedFilter>(entity =>
            {
                entity.ToTable("OrgSavedFilters", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrgSavedFilters)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.OrgSavedFilters_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<OrgSavedFilterCustomField>(entity =>
            {
                entity.ToTable("OrgSavedFilterCustomFields", "dbo");

                entity.HasIndex(e => e.SavedFilterId, "IX_SavedFilter_Id");

                entity.Property(e => e.SavedFilterId).HasColumnName("SavedFilter_Id");

                entity.HasOne(d => d.SavedFilter)
                    .WithMany(p => p.OrgSavedFilterCustomFields)
                    .HasForeignKey(d => d.SavedFilterId)
                    .HasConstraintName("FK_dbo.OrgSavedFilterCustomFields_dbo.OrgSavedFilters_SavedFilter_Id");
            });

            modelBuilder.Entity<OrgTodoType>(entity =>
            {
                entity.ToTable("OrgTodoTypes", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(128)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrgTodoTypes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.OrgTodoTypes_dbo.AspNetUsers_UserID");
            });

            modelBuilder.Entity<Organisation>(entity =>
            {
                entity.ToTable("Organisations", "dbo");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.ContactPerson).HasMaxLength(512);

                entity.Property(e => e.Name).HasMaxLength(512);
            });

            modelBuilder.Entity<OutlookIntegration>(entity =>
            {
                entity.ToTable("OutlookIntegrations", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.OutlookIntegrationId).HasColumnName("OutlookIntegrationID");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OutlookIntegrations)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.OutlookIntegrations_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<PayPalLog>(entity =>
            {
                entity.ToTable("PayPalLogs", "dbo");

                entity.Property(e => e.PayPalLogId).HasColumnName("PayPalLogID");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<PayPalTransaction>(entity =>
            {
                entity.ToTable("PayPalTransactions", "dbo");

                entity.Property(e => e.PayPalTransactionId).HasColumnName("PayPalTransactionID");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.McFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.McGross).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<PresetUserDatum>(entity =>
            {
                entity.ToTable("PresetUserData", "dbo");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Process>(entity =>
            {
                entity.ToTable("Processes", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Processes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Processes_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<ProcessContact>(entity =>
            {
                entity.HasKey(e => new { e.ProcessProcessId, e.ContactsContactId })
                    .HasName("PK_dbo.ProcessContacts");

                entity.ToTable("ProcessContacts", "dbo");

                entity.HasIndex(e => e.ContactsContactId, "IX_Contacts_ContactID");

                entity.HasIndex(e => e.ProcessProcessId, "IX_Process_ProcessID");

                entity.Property(e => e.ProcessProcessId).HasColumnName("Process_ProcessID");

                entity.Property(e => e.ContactsContactId).HasColumnName("Contacts_ContactID");

                entity.HasOne(d => d.ContactsContact)
                    .WithMany(p => p.ProcessContacts)
                    .HasForeignKey(d => d.ContactsContactId)
                    .HasConstraintName("FK_dbo.ProcessContacts_dbo.Contacts_Contacts_ContactID");

                entity.HasOne(d => d.ProcessProcess)
                    .WithMany(p => p.ProcessContacts)
                    .HasForeignKey(d => d.ProcessProcessId)
                    .HasConstraintName("FK_dbo.ProcessContacts_dbo.Processes_Process_ProcessID");
            });

            modelBuilder.Entity<ProcessStep>(entity =>
            {
                entity.HasKey(e => e.StepId)
                    .HasName("PK_dbo.ProcessSteps");

                entity.ToTable("ProcessSteps", "dbo");

                entity.HasIndex(e => e.ProcessId, "IX_ProcessID");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.StepId).HasColumnName("StepID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DoBy).HasColumnType("datetime");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.StepDescription).HasMaxLength(250);

                entity.Property(e => e.StepName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.ProcessSteps)
                    .HasForeignKey(d => d.ProcessId)
                    .HasConstraintName("FK_dbo.ProcessSteps_dbo.Processes_ProcessID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProcessSteps)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ProcessSteps_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Products", "dbo");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductName).IsRequired();

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Products_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Projects", "dbo");

                entity.HasIndex(e => e.ContactId, "IX_ContactID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.CompleteBy).HasColumnType("datetime");

                entity.Property(e => e.ContactId)
                    .HasColumnName("ContactID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.OrgId)
                    .HasColumnName("OrgID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectName).IsRequired();

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_dbo.Projects_dbo.Contacts_ContactID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Projects_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<ProjectNote>(entity =>
            {
                entity.ToTable("ProjectNotes", "dbo");

                entity.HasIndex(e => e.ProjectId, "IX_ProjectID");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.ProjectNoteId).HasColumnName("ProjectNoteID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DoBy).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectNotes)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_dbo.ProjectNotes_dbo.Projects_ProjectID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProjectNotes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ProjectNotes_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<ProviderPayment>(entity =>
            {
                entity.ToTable("ProviderPayments", "dbo");

                entity.HasIndex(e => e.ProviderPaymentId, "IX_ProviderPaymentID");

                entity.Property(e => e.ProviderPaymentId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProviderPaymentID");

                entity.Property(e => e.DatePaid).HasColumnType("datetime");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.ProviderPaymentNavigation)
                    .WithOne(p => p.ProviderPayment)
                    .HasForeignKey<ProviderPayment>(d => d.ProviderPaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ProviderPayments_dbo.PayPalTransactions_ProviderPaymentID");
            });

            modelBuilder.Entity<QuickNote>(entity =>
            {
                entity.ToTable("QuickNotes", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.Note).IsRequired();

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.QuickNotes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.QuickNotes_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<Quote>(entity =>
            {
                entity.ToTable("Quotes", "dbo");

                entity.HasIndex(e => e.AssignedUserId, "IX_AssignedUserID");

                entity.HasIndex(e => e.ContactId, "IX_ContactID");

                entity.HasIndex(e => e.OrgId, "IX_OrgID");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.QuoteId).HasColumnName("QuoteID");

                entity.Property(e => e.AssignedUserId)
                    .HasMaxLength(128)
                    .HasColumnName("AssignedUserID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactNote).HasMaxLength(1024);

                entity.Property(e => e.DateAccepted).HasColumnType("datetime");

                entity.Property(e => e.DateClosed).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.MyNote).HasMaxLength(1024);

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.Property(e => e.QuoteName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.AssignedUser)
                    .WithMany(p => p.QuoteAssignedUsers)
                    .HasForeignKey(d => d.AssignedUserId)
                    .HasConstraintName("FK_dbo.Quotes_dbo.AspNetUsers_AssignedUserID");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Quotes)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_dbo.Quotes_dbo.Contacts_ContactID");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.Quotes)
                    .HasForeignKey(d => d.OrgId)
                    .HasConstraintName("FK_dbo.Quotes_dbo.Orgs_OrgID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.QuoteUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Quotes_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<QuoteItem>(entity =>
            {
                entity.ToTable("QuoteItems", "dbo");

                entity.HasIndex(e => e.ProductId, "IX_ProductID");

                entity.HasIndex(e => e.QuoteId, "IX_QuoteID");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.QuoteItemId).HasColumnName("QuoteItemID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QuoteId).HasColumnName("QuoteID");

                entity.Property(e => e.QuoteItemDescription).HasMaxLength(1024);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.QuoteItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.QuoteItems_dbo.Products_ProductID");

                entity.HasOne(d => d.Quote)
                    .WithMany(p => p.QuoteItems)
                    .HasForeignKey(d => d.QuoteId)
                    .HasConstraintName("FK_dbo.QuoteItems_dbo.Quotes_QuoteID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.QuoteItems)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.QuoteItems_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<QuotesSavedFilter>(entity =>
            {
                entity.ToTable("QuotesSavedFilters", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.QuotesSavedFilters)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.QuotesSavedFilters_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<Ritual>(entity =>
            {
                entity.ToTable("Rituals", "dbo");

                entity.Property(e => e.RitualId).HasColumnName("RitualID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.RitualDayIds)
                    .HasMaxLength(50)
                    .HasColumnName("RitualDayIDs");

                entity.Property(e => e.RitualDesc).HasMaxLength(250);

                entity.Property(e => e.RitualName).HasMaxLength(100);

                entity.Property(e => e.TimePeriods).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Rituals)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Rituals_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<RitualDay>(entity =>
            {
                entity.ToTable("RitualDays", "dbo");

                entity.Property(e => e.RitualDayId).HasColumnName("RitualDayID");

                entity.Property(e => e.DayId).HasColumnName("DayID");

                entity.Property(e => e.RitualId).HasColumnName("RitualID");

                entity.Property(e => e.TimePeriodId)
                    .HasColumnName("TimePeriodID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.RitualDays)
                    .HasForeignKey(d => d.DayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RitualDays_dbo.DayID");

                entity.HasOne(d => d.Ritual)
                    .WithMany(p => p.RitualDays)
                    .HasForeignKey(d => d.RitualId)
                    .HasConstraintName("FK_dbo.RitualDays_dbo.RitualID");

                entity.HasOne(d => d.TimePeriod)
                    .WithMany(p => p.RitualDays)
                    .HasForeignKey(d => d.TimePeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RitualDays_dbo.TimePeriodID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RitualDays)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RitualDays_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<SalesProcess>(entity =>
            {
                entity.ToTable("SalesProcesses", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.SalesProcessName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SalesProcesses)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.SalesProcesses_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<SalesStep>(entity =>
            {
                entity.ToTable("SalesSteps", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SalesProcessId).HasColumnName("SalesProcessID");

                entity.Property(e => e.StepName).IsRequired();

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.SalesProcess)
                    .WithMany(p => p.SalesSteps)
                    .HasForeignKey(d => d.SalesProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.SalesSteps_dbo.SalesProcesses_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SalesSteps)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.SalesSteps_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<SalesStepGroup>(entity =>
            {
                entity.ToTable("SalesStepGroups", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SalesStepGroups)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.SalesStepGroups_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<SamTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sam_test", "dbo");

                entity.Property(e => e.Column1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("column1");
            });

            modelBuilder.Entity<SetActivityType>(entity =>
            {
                entity.ToTable("SetActivityTypes", "dbo");

                entity.Property(e => e.SetActivityTypeId).ValueGeneratedNever();

                entity.Property(e => e.SetActivtyTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SkypeCall>(entity =>
            {
                entity.ToTable("SkypeCalls", "dbo");

                entity.Property(e => e.SkypeCallId).HasColumnName("SkypeCallID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.SkypeCalls)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SkypeCalls_dbo.ContactID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SkypeCalls)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SkypeCalls_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<Source>(entity =>
            {
                entity.ToTable("Sources", "dbo");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Sources)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Sources_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("Subjects", "dbo");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.SubjectDesc).HasMaxLength(250);

                entity.Property(e => e.SubjectTitle)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Subjects_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<SubjectUser>(entity =>
            {
                entity.ToTable("SubjectUsers", "dbo");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(128);

                entity.Property(e => e.SubjectUserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.SubjectUsers)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.UserDetails_dbo.Subjects_SubjectID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SubjectUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.SubjectUsers_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<SubscriptionReminderEmail>(entity =>
            {
                entity.ToTable("SubscriptionReminderEmails", "dbo");

                entity.Property(e => e.SubscriptionReminderEmailId).HasColumnName("SubscriptionReminderEmailID");

                entity.Property(e => e.TemplateId).IsRequired();
            });

            modelBuilder.Entity<SystemEmail>(entity =>
            {
                entity.ToTable("SystemEmails", "dbo");

                entity.Property(e => e.SystemEmailId).HasColumnName("SystemEmailID");

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(512);
            });

            modelBuilder.Entity<SystemEmailSubscription>(entity =>
            {
                entity.ToTable("SystemEmailSubscriptions", "dbo");

                entity.HasIndex(e => e.LastSystemEmailId, "IX_LastSystemEmailId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.SystemEmailSubscriptionId).HasColumnName("SystemEmailSubscriptionID");

                entity.Property(e => e.LastSystemEmailDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.LastSystemEmail)
                    .WithMany(p => p.SystemEmailSubscriptions)
                    .HasForeignKey(d => d.LastSystemEmailId)
                    .HasConstraintName("FK_dbo.SystemEmailSubscriptions_dbo.SystemEmails_LastSystemEmailId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SystemEmailSubscriptions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.SystemEmailSubscriptions_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<Template>(entity =>
            {
                entity.ToTable("Templates", "dbo");

                entity.HasIndex(e => e.TemplateTypeId, "IX_TemplateTypeID");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.TemplateTypeId).HasColumnName("TemplateTypeID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.TemplateType)
                    .WithMany(p => p.Templates)
                    .HasForeignKey(d => d.TemplateTypeId)
                    .HasConstraintName("FK_dbo.Templates_dbo.TemplateTypes_TemplateTypeID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Templates)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Templates_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<TemplateType>(entity =>
            {
                entity.ToTable("TemplateTypes", "dbo");

                entity.Property(e => e.TemplateTypeId).HasColumnName("TemplateTypeID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TemplateTypes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TemplateTypes_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<TermsAndCondition>(entity =>
            {
                entity.ToTable("TermsAndConditions", "dbo");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TimePeriod>(entity =>
            {
                entity.ToTable("TimePeriods", "dbo");

                entity.Property(e => e.TimePeriodId).HasColumnName("TimePeriodID");

                entity.Property(e => e.PeriodName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Todo>(entity =>
            {
                entity.ToTable("Todoes", "dbo");

                entity.HasIndex(e => e.AssignedUserId, "IX_AssignedUserID");

                entity.HasIndex(e => e.ContactId, "IX_ContactID");

                entity.HasIndex(e => e.ContactToDoFieldId, "IX_ContactToDoFieldID");

                entity.HasIndex(e => e.MarketingListId, "IX_MarketingListID");

                entity.HasIndex(e => e.OpportunityId, "IX_OpportunityID");

                entity.HasIndex(e => e.OrgId, "IX_OrgID");

                entity.HasIndex(e => e.OrgTodoTypeId, "IX_OrgTodoTypeID");

                entity.HasIndex(e => e.StatusId, "IX_StatusID");

                entity.HasIndex(e => e.ToDoTypeId, "IX_ToDoTypeID");

                entity.Property(e => e.TodoId).HasColumnName("TodoID");

                entity.Property(e => e.AssignedUserId)
                    .HasMaxLength(128)
                    .HasColumnName("AssignedUserID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactToDoFieldId).HasColumnName("ContactToDoFieldID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateDone).HasColumnType("datetime");

                entity.Property(e => e.DoBy).HasColumnType("datetime");

                entity.Property(e => e.ExtarnalId).HasMaxLength(32);

                entity.Property(e => e.MarketingListId).HasColumnName("MarketingListID");

                entity.Property(e => e.OpportunityId).HasColumnName("OpportunityID");

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.Property(e => e.OrgTodoTypeId).HasColumnName("OrgTodoTypeID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.ToDoTypeId).HasColumnName("ToDoTypeID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.AssignedUser)
                    .WithMany(p => p.TodoAssignedUsers)
                    .HasForeignKey(d => d.AssignedUserId)
                    .HasConstraintName("FK_dbo.Todoes_dbo.AspNetUsers_AllocatedUserID");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Todos)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_dbo.Todoes_dbo.Contacts_ContactID");

                entity.HasOne(d => d.ContactToDoField)
                    .WithMany(p => p.Todos)
                    .HasForeignKey(d => d.ContactToDoFieldId)
                    .HasConstraintName("FK_dbo.Todoes_dbo.ContactToDoFields_ContactToDoFieldID");

                entity.HasOne(d => d.MarketingList)
                    .WithMany(p => p.Todos)
                    .HasForeignKey(d => d.MarketingListId)
                    .HasConstraintName("FK_dbo.Todoes_dbo.MarketingLists_MarketingListID");

                entity.HasOne(d => d.Opportunity)
                    .WithMany(p => p.Todos)
                    .HasForeignKey(d => d.OpportunityId)
                    .HasConstraintName("FK_dbo.Todoes_dbo.Opportunities_OpportunityID");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.Todos)
                    .HasForeignKey(d => d.OrgId)
                    .HasConstraintName("FK_dbo.Todoes_dbo.Orgs_OrgID");

                entity.HasOne(d => d.OrgTodoType)
                    .WithMany(p => p.Todos)
                    .HasForeignKey(d => d.OrgTodoTypeId)
                    .HasConstraintName("FK_dbo.Todoes_dbo.OrgTodoTypes_OrgTodoTypeID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Todos)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_dbo.Todoes_dbo.TodoStatus_StatusID");

                entity.HasOne(d => d.ToDoType)
                    .WithMany(p => p.Todos)
                    .HasForeignKey(d => d.ToDoTypeId)
                    .HasConstraintName("FK_dbo.Todoes_dbo.TodoCategories_ToDoTypeID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TodoUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Todoes_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<TodoCategory>(entity =>
            {
                entity.HasKey(e => e.TodoTypeId)
                    .HasName("PK_dbo.TodoCategories");

                entity.ToTable("TodoCategories", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.TodoTypeId).HasColumnName("TodoTypeID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.TodoTypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TodoCategories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.TodoCategories_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<TodoCustomSelect>(entity =>
            {
                entity.ToTable("TodoCustomSelects", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TodoCustomSelects)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.TodoCustomSelects_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<TodoCustomSelectItem>(entity =>
            {
                entity.ToTable("TodoCustomSelectItems", "dbo");

                entity.HasIndex(e => e.SelectId, "IX_SelectId");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Select)
                    .WithMany(p => p.TodoCustomSelectItems)
                    .HasForeignKey(d => d.SelectId)
                    .HasConstraintName("FK_dbo.TodoCustomSelectItems_dbo.TodoCustomSelects_SelectId");
            });

            modelBuilder.Entity<TodoCustomSelectValue>(entity =>
            {
                entity.HasKey(e => new { e.TodoId, e.SelectItemId })
                    .HasName("PK_dbo.TodoCustomSelectValues");

                entity.ToTable("TodoCustomSelectValues", "dbo");

                entity.HasIndex(e => e.SelectItemId, "IX_SelectItemId");

                entity.HasIndex(e => e.TodoId, "IX_TodoId");

                entity.HasOne(d => d.SelectItem)
                    .WithMany(p => p.TodoCustomSelectValues)
                    .HasForeignKey(d => d.SelectItemId)
                    .HasConstraintName("FK_dbo.TodoCustomSelectValues_dbo.TodoCustomSelectItems_SelectItemId");

                entity.HasOne(d => d.Todo)
                    .WithMany(p => p.TodoCustomSelectValues)
                    .HasForeignKey(d => d.TodoId)
                    .HasConstraintName("FK_dbo.TodoCustomSelectValues_dbo.Todoes_TodoId");
            });

            modelBuilder.Entity<TodoNote>(entity =>
            {
                entity.ToTable("TodoNotes", "dbo");

                entity.HasIndex(e => e.TodoId, "IX_TodoId");

                entity.HasIndex(e => e.UserId, "IX_UserID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(128)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Todo)
                    .WithMany(p => p.TodoNotes)
                    .HasForeignKey(d => d.TodoId)
                    .HasConstraintName("FK_dbo.TodoNotes_dbo.Todoes_TodoId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TodoNotes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.TodoNotes_dbo.AspNetUsers_UserID");
            });

            modelBuilder.Entity<TodoSavedFilter>(entity =>
            {
                entity.ToTable("TodoSavedFilters", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TodoSavedFilters)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.TodoSavedFilters_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<TodoSavedFilterCustomField>(entity =>
            {
                entity.ToTable("TodoSavedFilterCustomFields", "dbo");

                entity.HasIndex(e => e.SavedFilterId, "IX_SavedFilter_Id");

                entity.Property(e => e.SavedFilterId).HasColumnName("SavedFilter_Id");

                entity.HasOne(d => d.SavedFilter)
                    .WithMany(p => p.TodoSavedFilterCustomFields)
                    .HasForeignKey(d => d.SavedFilterId)
                    .HasConstraintName("FK_dbo.TodoSavedFilterCustomFields_dbo.TodoSavedFilters_SavedFilter_Id");
            });

            modelBuilder.Entity<TodoStatus>(entity =>
            {
                entity.ToTable("TodoStatus", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(128)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TodoStatuses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.TodoStatus_dbo.AspNetUsers_UserID");
            });

            modelBuilder.Entity<UserContactForm>(entity =>
            {
                entity.ToTable("UserContactForms", "dbo");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserContactForms)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserContactForms_AspNetUsers");
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.ToTable("UserDetails", "dbo");

                entity.Property(e => e.CompanyAddress).HasMaxLength(2048);

                entity.Property(e => e.CompanyName).HasMaxLength(2048);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderCode)
                    .HasMaxLength(32)
                    .IsFixedLength(true);

                entity.Property(e => e.TelephoneNumber).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Website).HasMaxLength(256);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.UserDetails_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<UserDiskUsage>(entity =>
            {
                entity.ToTable("UserDiskUsages", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserDiskUsageId).HasColumnName("UserDiskUsageID");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserDiskUsages)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.UserDiskUsages_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<UserOnBoardDoneTask>(entity =>
            {
                entity.ToTable("UserOnBoardDoneTasks", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.OnBoardTaskId).HasColumnName("OnBoardTaskID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UserOnBoardTask>(entity =>
            {
                entity.HasKey(e => e.UserOnBoardId)
                    .HasName("PK_dbo.UserOnBoardTasks");

                entity.ToTable("UserOnBoardTasks", "dbo");

                entity.Property(e => e.UserOnBoardId).HasColumnName("UserOnBoardID");

                entity.Property(e => e.TaskUrl).HasColumnName("TaskURL");
            });

            modelBuilder.Entity<UserProvider>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserProv__1788CC4C0AAF1254");

                entity.ToTable("UserProviders", "dbo");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserProvider)
                    .HasForeignKey<UserProvider>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.UserProviders_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<UserSetting>(entity =>
            {
                entity.ToTable("UserSettings", "dbo");

                entity.Property(e => e.ContactActivities)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DailyRituals)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EmailSignature).HasMaxLength(2048);

                entity.Property(e => e.FollowUpManager)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Friday)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Gdprconsents)
                    .IsRequired()
                    .HasColumnName("GDPRConsents")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HoursPerDay)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImapFolders).HasMaxLength(1024);

                entity.Property(e => e.ImapIsRequireSsl).HasColumnName("ImapIsRequireSSL");

                entity.Property(e => e.ImapPassword).HasMaxLength(512);

                entity.Property(e => e.ImapServer).HasMaxLength(256);

                entity.Property(e => e.ImapUsername).HasMaxLength(512);

                entity.Property(e => e.Invoices)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowJumpStartTabOnHomePage)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Jobs)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Lists)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MailChimpApiKey).HasMaxLength(128);

                entity.Property(e => e.MailjetApiKeyPrivate).HasMaxLength(512);

                entity.Property(e => e.MailjetApiKeyPublic).HasMaxLength(512);

                entity.Property(e => e.Monday)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Opportunities)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Projects)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Quotes)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Reports)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Saturday)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SmtpFromAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SmtpPassword)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SmtpPort)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SmtpServer)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SmtpUsername)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sunday)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Thursday)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Todos)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tuesday)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Wednesday)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSettings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.UserSettings_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<UserTracking>(entity =>
            {
                entity.ToTable("UserTrackings", "dbo");

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.LogoutTime).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTrackings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserTrack__UserI__6BAEFA67");
            });

            modelBuilder.Entity<VactWorkRec>(entity =>
            {
                entity.ToTable("VActWorkRecs", "dbo");

                entity.Property(e => e.VactWorkRecId).HasColumnName("VActWorkRecID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.Property(e => e.VactivityDescription).HasColumnName("VActivityDescription");

                entity.Property(e => e.VactivityName).HasColumnName("VActivityName");

                entity.Property(e => e.VtimeWorkTaken).HasColumnName("VTimeWorkTaken");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VactWorkRecs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.VActWorkRecs_dbo.AspNetUsers_Id");
            });

            modelBuilder.Entity<ViewContactsList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_ContactsList", "dbo");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.FullName).IsRequired();

                entity.Property(e => e.Industry).HasMaxLength(250);

                entity.Property(e => e.Source).HasMaxLength(150);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<WebJob>(entity =>
            {
                entity.ToTable("WebJobs", "dbo");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.WebJobId).HasColumnName("WebJobID");

                entity.Property(e => e.LastRunDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WebJobs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.WebJobs_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<WorkRecord>(entity =>
            {
                entity.ToTable("WorkRecords", "dbo");

                entity.Property(e => e.WorkRecordId).HasColumnName("WorkRecordID");

                entity.Property(e => e.DateDone).HasColumnType("datetime");

                entity.Property(e => e.RitualId).HasColumnName("RitualID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('7d8422a6-03e6-4cd5-92ab-cc786058d03f')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WorkRecords)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.WorkRecords_dbo.AspNetUsers_Id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
