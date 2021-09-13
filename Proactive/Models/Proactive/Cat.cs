using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Cat
    {
        public int CatId { get; set; }
        public string ControllerName { get; set; }
        public string ActionMethodName { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
