using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class UserTracking
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
