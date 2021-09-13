using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class FeatureFlag
    {
        public int FeatId { get; set; }
        public string FeatureName { get; set; }
        public bool Enabled { get; set; }
    }
}
