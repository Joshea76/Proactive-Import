using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class SubscriptionReminderEmail
    {
        public int SubscriptionReminderEmailId { get; set; }
        public string TemplateId { get; set; }
        public bool Published { get; set; }
        public int SendDay { get; set; }
    }
}
