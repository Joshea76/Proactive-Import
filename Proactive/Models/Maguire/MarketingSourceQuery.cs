using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MarketingSourceQuery
    {
        public int QueId { get; set; }
        public int RulId { get; set; }
        public string QuerySql { get; set; }
        public string QueryGvSerialised { get; set; }

        public virtual MarketingSourceRule Rul { get; set; }
    }
}
