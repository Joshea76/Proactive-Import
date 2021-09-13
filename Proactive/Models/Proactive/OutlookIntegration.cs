using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class OutlookIntegration
    {
        public int OutlookIntegrationId { get; set; }
        public string UserId { get; set; }
        public string TokenType { get; set; }
        public string Scope { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
