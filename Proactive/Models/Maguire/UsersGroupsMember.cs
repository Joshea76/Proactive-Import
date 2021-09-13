using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class UsersGroupsMember
    {
        public Guid UsmId { get; set; }
        public Guid? UsId { get; set; }
        public Guid? UsgId { get; set; }
        public bool? PrimaryGroup { get; set; }
        public bool? Manager { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool ShareEmail { get; set; }

        public virtual UsersGroup Usg { get; set; }
    }
}
