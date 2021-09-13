using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class AnnouncementEmail
    {
        public int AnnouncementEmailId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool Published { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
