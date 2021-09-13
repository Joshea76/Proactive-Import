using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class DynamicLabel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string MiscField1 { get; set; }
        public string MiscField2 { get; set; }
        public string MiscField3 { get; set; }
        public string MiscField4 { get; set; }
        public DateTime? DateCreated { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
