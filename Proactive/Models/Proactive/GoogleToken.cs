using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class GoogleToken
    {
        public int GoogleTokenId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
