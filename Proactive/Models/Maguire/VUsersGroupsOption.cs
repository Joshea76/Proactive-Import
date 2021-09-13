using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VUsersGroupsOption
    {
        public string GroupName { get; set; }
        public string AcoType { get; set; }
        public string AcoLabel { get; set; }
        public Guid? GroId { get; set; }
        public bool AllowEdit { get; set; }
        public bool AllowDelete { get; set; }
        public Guid AcoId { get; set; }
        public Guid UsgId { get; set; }
        public int Order { get; set; }
        public string AccessArea { get; set; }
    }
}
