using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Country
    {
        public Country()
        {
            Contacts = new HashSet<Contact>();
            OrgBillableCountries = new HashSet<Org>();
            OrgCountryCountries = new HashSet<Org>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Org> OrgBillableCountries { get; set; }
        public virtual ICollection<Org> OrgCountryCountries { get; set; }
    }
}
