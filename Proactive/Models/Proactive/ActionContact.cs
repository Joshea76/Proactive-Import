using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class ActionContact
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ContactId { get; set; }
    }
}
