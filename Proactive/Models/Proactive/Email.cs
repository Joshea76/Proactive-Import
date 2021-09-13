using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Email
    {
        public Email()
        {
            Activities = new HashSet<Activity>();
        }

        public int Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime Timestamp { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
    }
}
