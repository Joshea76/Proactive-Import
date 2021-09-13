using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class UserContactForm
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
