using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class MySetting
    {
        public int MySettingsId { get; set; }
        public double HoursPerDay { get; set; }
        public string ProviderKey { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
