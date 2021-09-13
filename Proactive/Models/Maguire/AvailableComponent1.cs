using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AvailableComponent1
    {
        public Guid AvailableComponentId { get; set; }
        public int Type { get; set; }
        public string DefaultTitle { get; set; }
        public string ImagePath { get; set; }
        public bool EnabledOnLandingPage { get; set; }
    }
}
