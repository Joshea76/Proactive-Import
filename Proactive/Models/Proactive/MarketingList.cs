using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class MarketingList
    {
        public MarketingList()
        {
            Campaigns = new HashSet<Campaign>();
            Todos = new HashSet<Todo>();
        }

        public int MarketingListId { get; set; }
        public string ListName { get; set; }
        public string ListDesc { get; set; }
        public int? ContactAndListId { get; set; }
        public DateTime DateCreated { get; set; }
        public int? ReminderDays { get; set; }
        public int ListType { get; set; }
        public string UserId { get; set; }
        public int? ProcessId { get; set; }

        public virtual ContactAndList ContactAndList { get; set; }
        public virtual AspNetUser User { get; set; }
        public virtual ICollection<Campaign> Campaigns { get; set; }
        public virtual ICollection<Todo> Todos { get; set; }
    }
}
