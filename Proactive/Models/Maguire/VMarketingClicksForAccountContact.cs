using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VMarketingClicksForAccountContact
    {
        public int MclId { get; set; }
        public Guid McsrId { get; set; }
        public Guid AccId { get; set; }
        public int? CsId { get; set; }
        public DateTime DateClicked { get; set; }
        public string Url { get; set; }
        public string Summary { get; set; }
        public Guid StgId { get; set; }
        public string StgSummary { get; set; }
        public Guid McaId { get; set; }
        public string McaSummary { get; set; }
        public Guid? AcId { get; set; }
        public string AccSummary { get; set; }
        public int PrimaryContact { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
