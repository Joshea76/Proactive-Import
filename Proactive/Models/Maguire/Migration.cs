using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Migration
    {
        public Guid MigId { get; set; }
        public string Filename { get; set; }
        public int? Order { get; set; }
    }
}
