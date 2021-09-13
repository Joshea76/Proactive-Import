using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class QuotesSavedFilter
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Org { get; set; }
        public string AssignedUser { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
