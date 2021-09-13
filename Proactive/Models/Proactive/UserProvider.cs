using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class UserProvider
    {
        public string UserId { get; set; }
        public string ProviderId { get; set; }
        public DateTime DateAdded { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
