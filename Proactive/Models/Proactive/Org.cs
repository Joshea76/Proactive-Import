using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Org
    {
        public Org()
        {
            ContactNotes = new HashSet<ContactNote>();
            ContactOrgOrgs = new HashSet<Contact>();
            ContactOrgs = new HashSet<Contact>();
            DomainActivities = new HashSet<DomainActivity>();
            OrgCustomSelectValues = new HashSet<OrgCustomSelectValue>();
            Quotes = new HashSet<Quote>();
            Todos = new HashSet<Todo>();
        }

        public int OrgId { get; set; }
        public string OrgName { get; set; }
        public int DisplayOrg { get; set; }
        public string UserId { get; set; }
        public string TelNo { get; set; }
        public string PostCode { get; set; }
        public string Note { get; set; }
        public DateTime DateCreated { get; set; }
        public int? MainContactId { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public int? CountryId { get; set; }
        public string Website { get; set; }
        public string AccountManagerId { get; set; }
        public string TelNo2 { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string BillableAddress1 { get; set; }
        public string BillableAddress2 { get; set; }
        public string BillableAddress3 { get; set; }
        public string BillableCity { get; set; }
        public string BillableCounty { get; set; }
        public string BillablePostCode { get; set; }
        public int? BillableCountryId { get; set; }
        public string BillableTelNo { get; set; }
        public string LinkedIn { get; set; }
        public int? BillableContactId { get; set; }
        public int? CountryCountryId { get; set; }

        public virtual AspNetUser AccountManager { get; set; }
        public virtual Contact BillableContact { get; set; }
        public virtual Country BillableCountry { get; set; }
        public virtual Country CountryCountry { get; set; }
        public virtual Contact MainContact { get; set; }
        public virtual AspNetUser User { get; set; }
        public virtual ICollection<ContactNote> ContactNotes { get; set; }
        public virtual ICollection<Contact> ContactOrgOrgs { get; set; }
        public virtual ICollection<Contact> ContactOrgs { get; set; }
        public virtual ICollection<DomainActivity> DomainActivities { get; set; }
        public virtual ICollection<OrgCustomSelectValue> OrgCustomSelectValues { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
        public virtual ICollection<Todo> Todos { get; set; }
    }
}
