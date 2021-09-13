using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserId { get; set; }
        public int MarketingListId { get; set; }

        public virtual MarketingList MarketingList { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
