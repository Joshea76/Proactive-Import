using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class ActivityType
    {
        public ActivityType()
        {
            Activities = new HashSet<Activity>();
        }

        public int ActivityTypeId { get; set; }
        public string ActivityName { get; set; }
        public string UserId { get; set; }
        public int? ActivityTypeSystem { get; set; }
        public DateTime? DateCreated { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
    }
}
