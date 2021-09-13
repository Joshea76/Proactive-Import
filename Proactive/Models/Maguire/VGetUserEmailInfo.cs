using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VGetUserEmailInfo
    {
        public Guid UsId { get; set; }
        public string Summary { get; set; }
        public string EmailAddress { get; set; }
    }
}
