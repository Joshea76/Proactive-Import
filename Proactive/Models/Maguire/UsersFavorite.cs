using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class UsersFavorite
    {
        public Guid? UsId { get; set; }
        public Guid? UsgId { get; set; }
        public Guid UsfId { get; set; }
        public bool? Class { get; set; }
        public string Type { get; set; }
        public string Summary { get; set; }
        public Guid? RefId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool Public { get; set; }
        public bool? OnMenu { get; set; }

        public virtual User Us { get; set; }
        public virtual UsersGroup Usg { get; set; }
    }
}
