using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class UsersReport
    {
        public Guid UreId { get; set; }
        public Guid UsId { get; set; }
        public Guid ReId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual Report Re { get; set; }
        public virtual User Us { get; set; }
    }
}
