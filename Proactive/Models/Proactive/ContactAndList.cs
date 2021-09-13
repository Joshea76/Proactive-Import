using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class ContactAndList
    {
        public ContactAndList()
        {
            MarketingLists = new HashSet<MarketingList>();
        }

        public int ContactAndListId { get; set; }
        public int ContactId { get; set; }
        public int MarketingListId { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<MarketingList> MarketingLists { get; set; }
    }
}
