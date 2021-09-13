using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DashboardGaugeChartThreshold
    {
        public Guid DgctId { get; set; }
        public decimal Threshold { get; set; }
        public string Colour { get; set; }
        public int? ThemeColour { get; set; }
        public int DshId { get; set; }
    }
}
