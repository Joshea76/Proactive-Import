using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class TodoNote
    {
        public int Id { get; set; }
        public int TodoId { get; set; }
        public string Note { get; set; }
        public string UserId { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual Todo Todo { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
