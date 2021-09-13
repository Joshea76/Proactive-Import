using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class SubjectUser
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public string UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public string SubjectUserId { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
