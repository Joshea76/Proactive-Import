using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VwOpportunityNotesList
    {
        public string Account { get; set; }
        public string Summary { get; set; }
        public string OpOwner { get; set; }
        public string OpContact { get; set; }
        public DateTime? EstimatedClose { get; set; }
        public decimal PotentialValue { get; set; }
        public decimal Probability { get; set; }
        public decimal ForecastValue { get; set; }
        public decimal Duration { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? UsId { get; set; }
        public Guid AcId { get; set; }
        public string Notes { get; set; }
    }
}
