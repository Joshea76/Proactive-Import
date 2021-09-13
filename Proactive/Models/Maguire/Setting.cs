using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Setting
    {
        public Guid SetId { get; set; }
        public string Setting1 { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public bool? Selected { get; set; }
    }
}
