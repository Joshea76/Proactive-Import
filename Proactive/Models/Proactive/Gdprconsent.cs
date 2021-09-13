using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Gdprconsent
    {
        public int ContactId { get; set; }
        public int? ConsentGiven { get; set; }
        public DateTime DateGiven { get; set; }
        public string Description { get; set; }
        public bool ConsentToWrite { get; set; }
        public bool ConsentToEmail { get; set; }
        public bool ConsentToCall { get; set; }
        public string UserId { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
