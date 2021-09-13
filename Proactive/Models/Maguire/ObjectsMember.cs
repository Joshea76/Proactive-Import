using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class ObjectsMember
    {
        public Guid OmId { get; set; }
        public Guid? ObjId { get; set; }
        public Guid? UsgId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Guid? Role { get; set; }
        public byte? Owner { get; set; }

        public virtual UsersGroup Usg { get; set; }
    }
}
