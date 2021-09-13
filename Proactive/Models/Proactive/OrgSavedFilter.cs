using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class OrgSavedFilter
    {
        public OrgSavedFilter()
        {
            OrgSavedFilterCustomFields = new HashSet<OrgSavedFilterCustomField>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public string AccountManager { get; set; }
        public string MainProduct { get; set; }
        public string AccountType { get; set; }
        public string OrgType { get; set; }
        public string Source { get; set; }
        public string Name { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<OrgSavedFilterCustomField> OrgSavedFilterCustomFields { get; set; }
    }
}
