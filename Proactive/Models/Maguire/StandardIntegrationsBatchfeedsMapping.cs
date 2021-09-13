using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class StandardIntegrationsBatchfeedsMapping
    {
        public Guid SibmId { get; set; }
        public Guid SibId { get; set; }
        public string GvField { get; set; }
        public string TpField { get; set; }
        public bool Static { get; set; }
    }
}
