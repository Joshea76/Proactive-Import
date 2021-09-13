using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Contact
    {
        public Contact()
        {
            Activities = new HashSet<Activity>();
            ChecklistContacts = new HashSet<ChecklistContact>();
            ContactFiles = new HashSet<ContactFile>();
            ContactNotes = new HashSet<ContactNote>();
            ContactToDoFieldValues = new HashSet<ContactToDoFieldValue>();
            DomainActivities = new HashSet<DomainActivity>();
            Invoices = new HashSet<Invoice>();
            JobHeaders = new HashSet<JobHeader>();
            Opportunities = new HashSet<Opportunity>();
            OpportunityStageHistories = new HashSet<OpportunityStageHistory>();
            OrgBillableContacts = new HashSet<Org>();
            OrgMainContacts = new HashSet<Org>();
            ProcessContacts = new HashSet<ProcessContact>();
            Projects = new HashSet<Project>();
            Quotes = new HashSet<Quote>();
            SkypeCalls = new HashSet<SkypeCall>();
            Todos = new HashSet<Todo>();
        }

        public int ContactId { get; set; }
        public string FullName { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public int? ContactTitleId { get; set; }
        public string JobTitle { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public int? CountryId { get; set; }
        public string TelNo { get; set; }
        public string TelNo2 { get; set; }
        public string Email { get; set; }
        public string SkypeId { get; set; }
        public string FacebookPage { get; set; }
        public string Website { get; set; }
        public string LinkedIn { get; set; }
        public string Twitter { get; set; }
        public string NextThing { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime DateAdded { get; set; }
        public int? ContactTypeId { get; set; }
        public string UserId { get; set; }
        public string YouTube { get; set; }
        public string Instagram { get; set; }
        public string Notes { get; set; }
        public string TextField1 { get; set; }
        public string TextField2 { get; set; }
        public string TextField3 { get; set; }
        public string TextField4 { get; set; }
        public string Industry { get; set; }
        public int? SalesProcessId { get; set; }
        public int? CurrentSalesStep { get; set; }
        public int? SourceId { get; set; }
        public int? MlistId { get; set; }
        public int? ImportMethod { get; set; }
        public bool IsMarked { get; set; }
        public bool DoNotEmail { get; set; }
        public string PhotoUrl { get; set; }
        public string Title { get; set; }
        public string SimpleOrgName { get; set; }
        public DateTime DateModified { get; set; }
        public int? OrgOrgId { get; set; }
        public int? OrgId { get; set; }

         public virtual ContactTitle ContactTitle { get; set; }
        public virtual ContactType ContactType { get; set; }
        public virtual Country Country { get; set; }
        public virtual SalesStep CurrentSalesStepNavigation { get; set; }
        public virtual Org Org { get; set; }
        public virtual Org OrgOrg { get; set; }
        public virtual SalesProcess SalesProcess { get; set; }
        public virtual Source Source { get; set; }
        public virtual AspNetUser User { get; set; }
        public virtual Gdprconsent Gdprconsent { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<ChecklistContact> ChecklistContacts { get; set; }
        public virtual ICollection<ContactFile> ContactFiles { get; set; }
        public virtual ICollection<ContactNote> ContactNotes { get; set; }
        public virtual ICollection<ContactToDoFieldValue> ContactToDoFieldValues { get; set; }
        public virtual ICollection<DomainActivity> DomainActivities { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<JobHeader> JobHeaders { get; set; }
        public virtual ICollection<Opportunity> Opportunities { get; set; }
        public virtual ICollection<OpportunityStageHistory> OpportunityStageHistories { get; set; }
        public virtual ICollection<Org> OrgBillableContacts { get; set; }
        public virtual ICollection<Org> OrgMainContacts { get; set; }
        public virtual ICollection<ProcessContact> ProcessContacts { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
        public virtual ICollection<SkypeCall> SkypeCalls { get; set; }
        public virtual ICollection<Todo> Todos { get; set; }
    }
}
